using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace MonetaVerdeWalletGUI
{
    public partial class Wallet : Form
    {
        string simplewalletPath;
        string deamonPath;
        string MinerCPath;
        string latestComment, latestCommentWallet;
        string balance;
        string balanceCleanStr;
        string walletAddress;
        string unconfbalanceStr;
        string bcHeightStr;
        StreamWriter StreamWriterWallet, StreamWriterDaemon, StreamWriterMiner;
        Process DeamonProcess, walletProcess,minerProcess;
        private Thread UpdThread = null;
        delegate void StringArgReturningVoidDelegate(string text);
        Boolean IsCheckingBCHeight;
        Login   LoginForm;
        StartMining StartMiningForm;
        string WalletUserName;
        string WalletPassWord;
        Boolean loggedInWallet;
        Settings    SettingsForm;
        SendCoins   SendCoinsForm;
        Boolean genWallet;
        Boolean openingWallet;
        Boolean mayMine;
        Boolean isMining;
        Boolean localDaemonRunning;
        Boolean requestingTransfers;
        string HR;
        int numOfThreadsForMining;
        AboutMonetaVerde AMVForm;
        String  transactionTX;
        int transactionCount;
        String  transactionAmount;
        string  transactionInOut;
        string transactionLeft;
        string transactionChopped;
        int transactionAmountToValue;
        System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();
        Boolean WriteTransBool;
        string remoteDaemonIPPlusPort;
        Boolean UseRemoteDaemon;
        LogManager Logger;
        int refreshHeightCurrent;
        int refreshHeightMax;
        string refHeightCurrentChunk;
        string refHeightMaxChunk;
        Boolean isRefreshing;
        Boolean mustCallRefresh;
        ListBox ExclNodesList;
        string ExclNodesString;


        public Wallet()
        {
            InitializeComponent();
        }

        public void setSettings(Boolean _useRemoteDaemon, string _remoteDaemonIPPlusPort, ListBox _ExclNodesList)
        {
            UseRemoteDaemon         = _useRemoteDaemon;
            remoteDaemonIPPlusPort  = _remoteDaemonIPPlusPort;
            ExclNodesList           = _ExclNodesList;
        }

        private void updWalletASync()
        {
            var delay = Task.Run(async () =>
            {
                await Task.Delay(5000);
                UpdateWallet();
                updWalletASync();
            });
        }
        private void Get_Address_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ShowAddress.Text);
            MessageBox.Show("Address copied to clipboard: \n" + ShowAddress.Text, "MONETAVERDE");
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            info.NumberDecimalSeparator = ".";
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //Here goes the code for initing
            DeamonStatus.Text   = "Stopped";
            loggedInWallet      = false;
            mayMine             = false;
            isMining            = false;
            localDaemonRunning  = false;
            UseRemoteDaemon         = false;
            remoteDaemonIPPlusPort  = "";
            startWalletMessage.Visible = true;
            isRefreshing = false;
            mustCallRefresh = false;
            
            MessageBox.Show("You are currently using an Alpha build, only use for test purposes. You are responsible for losses of funds.");

            Logger = new LogManager();
            Logger.InitLog();

            UpdateWallet();
        }

        private void createUpdateProgressBar(int _max, int _current)
        {
            ProgressSyncWallet.Minimum  = 0; //Always count from genesis
            ProgressSyncWallet.Maximum  = _max;
            ProgressSyncWallet.Value    = _current;
            BlockHeightWallet.Text = "Syncing wallet " + _current + " Of " + _max;
        }

        private void startWallet()
        {
            var args = new[] {
                UseRemoteDaemon?"--daemon-address " + remoteDaemonIPPlusPort:"",
                genWallet ?"--generate-new-wallet " + AppDomain.CurrentDomain.BaseDirectory + @"bin\\" + WalletUserName:"",
                genWallet?"":"--wallet-file " + AppDomain.CurrentDomain.BaseDirectory + @"bin\\" + WalletUserName,
                "--password " + WalletPassWord};
            //For debugging purposes, I don't want to change the location of the wallet
            simplewalletPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\\simplewallet.exe";

            if (File.Exists(simplewalletPath))
            {
                Console.WriteLine(String.Join(" ", args));
                ProcessStartInfo psi = new ProcessStartInfo(simplewalletPath, String.Join(" ", args))
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    RedirectStandardInput = true,//true,
                    RedirectStandardOutput = true//true
                };

                IsCheckingBCHeight = false;

                walletProcess = Process.Start(psi);
                walletProcess.EnableRaisingEvents = true;
                StreamWriterWallet = walletProcess.StandardInput;
                walletProcess.BeginOutputReadLine();

                walletProcess.OutputDataReceived += new DataReceivedEventHandler
                (
                    delegate (object sender, DataReceivedEventArgs e)
                    {
                        if (e.Data != null)
                        {
                            if (!e.Data.Contains("Height"))
                            {
                                //Avoid logging all refresh data
                                Logger.Log(e.Data, "Inbound", "Wallet");
                            }
                        }
                        // append the new data to the data already read-in
                        latestCommentWallet += e.Data + "\n";
                        //Interprit result
                        if (e.Data == null)
                        {
                            if (openingWallet)
                            {
                                MessageBox.Show("Error opening wallet");
                            }
                            //Do nothing
                        }
                        else if (e.Data.Contains("Starting refresh"))
                        {
                            //Refreshing data started
                            ProgressSyncWallet.Visible = true;
                            isRefreshing = true;
                        }
                        else if (e.Data.Contains("Refresh done"))
                        {
                            //Refreshing data started
                            ProgressSyncWallet.Visible = false;
                            isRefreshing = false;
                        }
                        else if (e.Data.Contains("Height"))
                        {
                            //Refreshing data
                            refHeightCurrentChunk = e.Data.Substring(7, e.Data.IndexOf("of")- 7);
                            refHeightMaxChunk = e.Data.Substring(e.Data.IndexOf("of") + 2);
                            refreshHeightCurrent = Convert.ToInt32(refHeightCurrentChunk);
                            refreshHeightMax     = Convert.ToInt32(refHeightMaxChunk);
                            createUpdateProgressBar(refreshHeightMax, refreshHeightCurrent);
                        }

                        else if (e.Data.Contains("tx id"))
                        {
                            TXAmounts.Items.Clear();
                            TXInOut.Items.Clear();
                            TXId.Items.Clear();
                            transactionCount = 0;
                            requestingTransfers = true;
                        }
                        else if (requestingTransfers && e.Data.Contains("\t"))
                        {
                            WriteTransBool = true;
                            transactionAmountToValue = e.Data.IndexOf("\t");
                            transactionAmount = e.Data.Substring(0, transactionAmountToValue).Replace(" ", "");

                            transactionLeft = e.Data.Substring(transactionAmountToValue + 2);
                            transactionAmountToValue = transactionLeft.IndexOf("\t");
                            transactionChopped = transactionLeft.Substring(0, transactionAmountToValue);
                            transactionInOut = transactionLeft.Contains("F") ? "-" : "+";
                            WriteTransBool = transactionLeft.Contains("F") ? false : true;
                            transactionLeft = transactionLeft.Substring(transactionAmountToValue + 2);
                            transactionTX = transactionLeft.Replace(" ", "");

                            if (WriteTransBool)
                            {
                                TXAmounts.Items.Add(transactionAmount);
                                TXInOut.Items.Add(transactionInOut);
                                TXId.Items.Add(transactionTX);
                                transactionCount++;
                            }
                        }
                        else if (IsCheckingBCHeight && !isRefreshing)
                        {
                            bcHeightStr = e.Data.Substring(17);
                            IsCheckingBCHeight = false;
                            BlockHeightWallet.Text = bcHeightStr;
                        }
                        else if (e.Data.Contains("Generated new wallet"))
                        {
                            walletAddress = e.Data.Substring(22);
                            loggedInWallet = true;
                            mustCallRefresh = true;
                            UpdateWallet();
                            MessageBox.Show("Congratulations: wallet generated!");
                            
                        }
                        else if (e.Data.Contains("Opened wallet"))
                        {
                            walletAddress = e.Data.Substring(15);
                            loggedInWallet = true;
                            Copy_Address.Visible = true;
                            UpdateWallet(); //First run once to fetch all, because the ASync only kicks in after 5 seconds
                            updWalletASync();
                        }
                        else if (e.Data.Contains("balance"))
                        {
                            balance = e.Data.Substring(e.Data.IndexOf("balance", 0));
                            writeBalance();
                        }
                        else if (e.Data.Contains("Money successfully sent, transaction"))
                        {
                            SendCoinsForm.WriteSuccess(e.Data);
                        }
                        else if (e.Data.Contains("Error"))
                        {
                            logOutWallet();
                            MessageBox.Show("Error in wallet: " + e.Data);
                        }
                        else
                        {
                            writeConsole();
                        }

                        openingWallet = false;
                    }

                 );
            }
            else
            {
                MessageBox.Show("Wallet file does not exist at location: " + simplewalletPath);
            }
        }

        //Write Wallet Receive Addresss
        public void UpdateWallet()
        {
            this.UpdThread =
                new Thread(new ThreadStart(this.ThreadUpdWalletReceiveAddress));

            this.UpdThread.Start();
            if (StreamWriterWallet != null)
            {
                StreamWriterWallet.WriteLine("incoming_transfers");
                IsCheckingBCHeight = true;
                StreamWriterWallet.WriteLine("bc_height");

                if (mustCallRefresh)
                {
                    StreamWriterWallet.WriteLine("refresh");    //Call refresh as data needs to be loaded
                    mustCallRefresh = false;
                }

                StreamWriterWallet.WriteLine("balance");
            }

            if (loggedInWallet)
            {
                Copy_Address.Visible = true;
            }
            else
            {
                Copy_Address.Visible = false;
            }

            startWalletMessage.Visible = loggedInWallet ? false : true;
        }
        private void ThreadUpdWalletReceiveAddress()
        {
            this.SetWalletReceiveAddress(walletAddress);
            this.SetLoginButtonText("dummy");
            this.SetEnableSendCoinsButton("dummy");
            this.SetEnableToggleMiningButton("dummy");
            
        }
        private void SetEnableToggleMiningButton(string text)
        {
            if (this.ToggleMining.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetEnableToggleMiningButton);
                this.Invoke(d, new object[] { "dummy" });
            }
            else
            {
                ToggleMining.Enabled = loggedInWallet;
                if (loggedInWallet)
                {
                    ToggleMining.Text = isMining ? "Stop mining" : "Start mining";
                }
                else
                {
                    ToggleMining.Text = "Login to mine";
                }
            }
        }

        private void SetEnableSendCoinsButton(string text)
        {
            if (this.SendCoins.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetEnableSendCoinsButton);
                this.Invoke(d, new object[] { "dummy" });
            }
            else
            {
                SendCoins.Enabled = loggedInWallet;
            }
        }

        private void SetLoginButtonText(string  text)
        {  
            if (this.ShowAddress.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetLoginButtonText);
                this.Invoke(d, new object[] { "dummy" });
            }
            else
            {
                LoginButton.Text = loggedInWallet == true?"Logout":"Login";
            }
        }

        private void SetWalletReceiveAddress(string text)
        {
            if (this.ShowAddress.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetWalletReceiveAddress);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                ShowAddress.Text = walletAddress;
            }
        }

        //Write Balance
        public void writeBalance()
        {
            this.UpdThread =
                new Thread(new ThreadStart(this.ThreadUpdBalance));

            this.UpdThread.Start();
        }
        private void ThreadUpdBalance()
        {
            if (balance != null)
            {
                balanceCleanStr = balance.Substring(9, 14);
                unconfbalanceStr = balance.Substring(43, 14);
                this.SetBalance(balanceCleanStr);
                this.SetUnconfBalance(unconfbalanceStr);
            }
        }

        private void SetBalance(string text)
        { 
            if (this.BalanceStr.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetBalance);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                BalanceStr.Text = text;
            }
        }
        private void SetUnconfBalance(string text)
        {
            if (this.UnconfBalance.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetUnconfBalance);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                UnconfBalance.Text = text;
            }
        }

        private void startMinerC()
        {
            //For debugging purposes, I don't want to change the location of the miner program
            MinerCPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\\minerC.exe";
            var args = new[] {
                //For now added the exclusive node hardcoded, todo: GUI set based on settings
                "--node1 127.0.0.1:26081",
                "--node2 127.0.0.1:26081",
                "--wallet1 " + walletAddress,
                "--wallet2 " + walletAddress,
                "--threads " + numOfThreadsForMining
            };

            if (File.Exists(MinerCPath))
            {
                Console.WriteLine(String.Join(" ", args));
                ProcessStartInfo psi = new ProcessStartInfo(MinerCPath, String.Join(" ", args))
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true
                };

                minerProcess = Process.Start(psi);
                minerProcess.EnableRaisingEvents = true;
                StreamWriterMiner = minerProcess.StandardInput;
                minerProcess.BeginOutputReadLine();
                minerProcess.OutputDataReceived += new DataReceivedEventHandler
                (
                    delegate (object sender, DataReceivedEventArgs e)
                    {
                        Logger.Log(e.Data, "Inbound", "MinerC");
                        // append the new data to the data already read-in
                        latestComment += e.Data + "\n";
                        writeConsole();

                        if (e.Data == null)
                        {
                        }

                        else if (e.Data.Contains("Hash rate"))
                        {
                            HR = e.Data;
                            HashRateStr.Text = e.Data;
                        }
                    }
                );
            }
            else
            {
                MessageBox.Show("MinerC application not found at location " + MinerCPath);
            }
        }


        //This is all daemon

        private void startDeamon()
        {
            //For debugging purposes, I don't want to change the location of the monetaverded deamon
            deamonPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\\monetaverded.exe";
            int cntr = ExclNodesList.Items.Count;
            int x;

            for (x=1;x<=cntr;x++)
            {
                ExclNodesList.SetSelected(x-1,true);
                ExclNodesString = ExclNodesString + ExclNodesList.SelectedItem.ToString() + " ";    //Add space to get difference
            }
            

            var args = new[] {
                //For now added the exclusive node hardcoded, todo: GUI set based on settings
                ExclNodesString///"--add-exclusive-node 144.217.4.93:26080﻿"
            };

            MessageBox.Show(ExclNodesString);

            if (File.Exists(deamonPath))
            {
                Console.WriteLine(String.Join(" ", args));
                ProcessStartInfo psi = new ProcessStartInfo(deamonPath, String.Join(" ", args))
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true
                };

                DeamonProcess = Process.Start(psi);
                DeamonProcess.EnableRaisingEvents = true;
                StreamWriterDaemon = DeamonProcess.StandardInput;
                DeamonProcess.BeginOutputReadLine();
                DeamonProcess.OutputDataReceived += new DataReceivedEventHandler
                (
                    delegate (object sender, DataReceivedEventArgs e)
                    {
                        Logger.Log(e.Data, "Inbound", "Daemon");
                        // append the new data to the data already read-in
                        latestComment += e.Data + "\n";
                        writeConsole();

                        if (e.Data.Contains("Run net_service loop"))
                        {
                            DeamonStatus.Text = "Running";
                            localDaemonRunning = true;
                        }
                        else if (e.Data.Contains("hashrate"))
                        {
                            HR = e.Data;
                            HashRateStr.Text = e.Data;
                        }
                    }
                );

                //process.Start();
                DeamonProcess.Exited += new EventHandler(DeamonStoppedEH);
            }
            else
            {
                MessageBox.Show("Daemon application not found at location " + deamonPath);
            }
        }

        // Handle Exited event and display process information.
        private void DeamonStoppedEH(object sender, System.EventArgs e)
        {
            this.UpdThread =
                new Thread(new ThreadStart(this.ThreadUpdDStop));

            this.UpdThread.Start();
            DeamonProcess.CancelOutputRead();
        }
        private void ThreadUpdDStop()
        {
            this.SetTextDstop("Stopped");
        }

        private void SetTextDstop(string text)
        {
            if (this.DeamonStatus.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextDstop);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                DeamonStatus.Text = text;
            }
        }

        public void writeConsole()
        {
            this.UpdThread =
                new Thread(new ThreadStart(this.ThreadUpdCons));

            this.UpdThread.Start();
        }
        private void ThreadUpdCons()
        {
            this.SetTextConsole(latestComment);
        }

        private void SetTextConsole(string text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.StreamConsoleWriter.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextConsole);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                StreamConsoleWriter.Text = text;
            }
        }

        private void DeamonStatus_Click(object sender, EventArgs e)
        {
            if (DeamonStatus.Text == "Running")
            {
                DeamonProcess.Kill();
                localDaemonRunning = false;
                UpdateWallet();
            }
            else if (DeamonStatus.Text == "Disabled" || DeamonStatus.Text == "Stopped")
            { 
                startDeamon();
                DeamonStatus.Text = "Starting";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Log("request balance", "Outbound", "Wallet");
            StreamWriterWallet.WriteLine("balance");
        }

        //Menu items handling
        private void Settings_Click(object sender, EventArgs e)
        {
            //Login
            SettingsForm = new Settings();
            SettingsForm.parmCaller(this);
            SettingsForm.parmSettings(UseRemoteDaemon, remoteDaemonIPPlusPort, ExclNodesList);
            SettingsForm.Show();
        }

        private void SendCoins_Click(object sender, EventArgs e)
        {
            //Login
            SendCoinsForm = new SendCoins();
            SendCoinsForm.parmCaller(this);
            SendCoinsForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!loggedInWallet)
            {
                //Login
                LoginForm = new Login();
                LoginForm.parmCaller(this);
                LoginForm.Show();
            }
            else
            {
                logOutWallet();
            }
        }

        private void logOutWallet()
        {
            //Logout
            if (StreamWriterWallet != null)
            {
                Logger.Log("exit", "Outbound", "Wallet");
                StreamWriterWallet.WriteLine("exit");
            }
            walletAddress = "";
            loggedInWallet = false;
            UpdateWallet();
            balanceCleanStr = "";
            unconfbalanceStr = "";
            TXAmounts.Items.Clear();
            TXInOut.Items.Clear();
            TXId.Items.Clear();

            BalanceStr.Text     = "0.00";
            UnconfBalance.Text  = "0.00";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://getmonetaverde.org");
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            //Open about form
            AMVForm = new AboutMonetaVerde();
            AMVForm.Show();
        }

        private void ToggleMining_Click(object sender, EventArgs e)
        {
            isMining = isMining ? false : true;

            if (isMining)
            {
                StartMiningForm = new StartMining();
                StartMiningForm.parmCaller(this);
                StartMiningForm.Show();
            }
            else
            {
                minerProcess.Kill();
                HashRateStr.Text = "Not active";
                UpdateWallet();
            }   
        }

        public void StartMiningFromGUI(int _numOfThreads)
        {
            numOfThreadsForMining = _numOfThreads;

            startMinerC();//ORIG: StreamWriterWallet.WriteLine("start_mining");
            UpdateWallet();
        }

        public void Login(string _userName, string _passWord, Boolean _genWallet)
        {
            genWallet       = _genWallet;
            WalletUserName  = _userName;
            WalletPassWord  = _passWord;

            openingWallet  = true;

            startWallet();                  //Start the (simple) wallet

        }
        public void PerformSendCoins(string _sendToAddress, string _paymentId, string _coins)
        {
            string toSend = "transfer 2 " + _sendToAddress + " " + _coins;
            if (_paymentId != "")
            {
                toSend += " " + _paymentId;
            }
            //For now, mixin level to 2
            StreamWriterWallet.WriteLine(toSend);
            Logger.Log(toSend, "Outbound", "Wallet / send coins");
        }
    }
}
