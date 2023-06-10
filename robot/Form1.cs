using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace robot
{
    public partial class Form1 : Form
    {
        #region ### Definicje poszczególnych bitów w słowie PC_COMMAND oraz PC_ROBOTSTS
        const int cmdMAN_Up = 1;
        const int cmdMAN_Dn = 2;
        const int cmdAuto_Mode = 4;
        const int cmdCycl_Strt = 8;
        const int cmdAlarm_PC = 16;
        const int cmdRst_Alarm = 32;
        const int cmdRst_LdZon = 64;
        const int cmdRst_UnZon = 128;
        const int cmdBckliLdZo = 256;
        const int cmdBckliUnZo = 512;
        const int cmdFoto1LdZo = 1024;
        const int cmdFoto2LdZo = 2048;
        const int cmdEFotoUnZo = 4096;
        const int cmdFotoUnZo = 8192;
        const int cmdEnblLdZo = 16384;
        const int cmdEnblUnZo = 32768;

        const int stsAUTO = 1;
        const int stsMANUAL = 2;
        const int stsInCYCLE = 4;
        const int stsALARM = 8;
        const int stsUnZoFull1 = 16;
        const int stsUnZoFull2 = 32;
        const int stsREADY = 64;
        const int stsSPARE = 128;
        const int stsLdZFoReq1 = 256;
        const int stsLdZFoReq2 = 512;
        const int stsUnZFoReq1 = 1024;
        const int stsUnZFoReq2 = 2048;
        const int stsLdZoReady = 4096;
        const int stsUnZoReady = 8192;
        const int stsLdZoEnbld = 16384;
        const int stsUnZoEnbld = 32768;
        #endregion

        #region ### Definicje komend
        const string sSF = "\x02SF\x03";
        const string sRUN = "\x02RN\x03";
        const string sSTOP = "\x02SP\x03";
        const string sSON = "\x02SO\x03";
        const string sSOFF = "\x02BR\x03";
        const string sPrgRST = "\x02RS,PRG\x03";
        const string sOK = "\x02OK\x03";
        const string sPCROBSTS = "\x02MR, PCROBOTSTS 0 \x03";
        const string sCIC_AUTO = "\x02MR, CICLO_AUTO 0 \x03";
        const string sPC_SPEED = "\x02MR, PCSPEED 0 \x03";
        const string sNTI_CAR1 = "\x02MR, NOTI_CAR(1) 5 \x03";
        const string sNTI_CAR2 = "\x02MR, NOTI_CAR(2) 5 \x03";
        const string sNTI_SCA1 = "\x02MR, NOTI_SCA(1) 5 \x03";
        const string sNTI_SCA2 = "\x02MR, NOTI_SCA(2) 5 \x03";
        const string sPC_Command = "\x02MW, 1 PC_COMMAND 0 ";

        const string sPC_SPEED_w = "\x02MW, 1 PCSPEED 0 ";
        const string sMISS_CAR_1 = "\x02MW, 1 MISS_CAR(1) 5 ";
        const string sMISS_CAR_2 = "\x02MW, 1 MISS_CAR(2) 5 ";
        const string sMISS_CAR_3 = "\x02MW, 1 MISS_CAR(3) 5 ";
        const string sMISS_CAR_4 = "\x02MW, 1 MISS_CAR(4) 5 ";
        const string sMISS_CAR_5 = "\x02MW, 1 MISS_CAR(5) 5 ";
        const string sMISS_CAR_6 = "\x02MW, 1 MISS_CAR(6) 5 ";
        const string sMISS_CAR_7 = "\x02MW, 1 MISS_CAR(7) 5 ";
        const string sMISS_CAR_8 = "\x02MW, 1 MISS_CAR(8) 5 ";
        const string sMISS_CAR_9 = "\x02MW, 1 MISS_CAR(9) 5 ";
        const string sMISS_CAR_10 = "\x02MW, 1 MISS_CAR(10) 5 ";
        const string sNOTI_CAR_1 = "\x02MW, 1 NOTI_CAR(1) 5 ";

        const string sMISS_SCA_1 = "\x02MW, 1 MISS_SCA(1) 5 ";
        const string sMISS_SCA_2 = "\x02MW, 1 MISS_SCA(2) 5 ";
        const string sMISS_SCA_3 = "\x02MW, 1 MISS_SCA(3) 5 ";
        const string sMISS_SCA_4 = "\x02MW, 1 MISS_SCA(4) 5 ";
        const string sMISS_SCA_5 = "\x02MW, 1 MISS_SCA(5) 5 ";
        const string sMISS_SCA_6 = "\x02MW, 1 MISS_SCA(6) 5 ";
        const string sMISS_SCA_7 = "\x02MW, 1 MISS_SCA(7) 5 ";
        const string sMISS_SCA_8 = "\x02MW, 1 MISS_SCA(8) 5 ";
        const string sMISS_SCA_9 = "\x02MW, 1 MISS_SCA(9) 5 ";
        const string sMISS_SCA_10 = "\x02MW, 1 MISS_SCA(10) 5 ";
        const string sNOTI_SCA_1 = "\x02MW, 1 NOTI_SCA(1) 5 ";

        #endregion

        private SerialPort serialPort;
        private Thread sendThread;
        private Semaphore sem1 = new Semaphore(1, 1);
        private Thread readFromport, backupThread;
        private SharedData sharedData = new SharedData();
        private ushort frame = 0x1234;
        SendDateToSerial robotCommunicationSend;
        private bool shouldStopReading = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicjalizacja ustawień portu szeregowego
                string[] listaPort = SerialPort.GetPortNames();              
                serialPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                // Otwarcie portu szeregowego
                robotCommunicationSend = new SendDateToSerial(serialPort);

                readFromport = new Thread(new ThreadStart(StartReading));
                readFromport.IsBackground = true;
                readFromport.Start();
            }
            catch(Exception ex)
			{
                MessageBox.Show(ex.Message);
			}        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sPC_Command = "\x02MW, 1 PC_COMMAND 0 ";
                int sPC_ipccommandval = 0xaabbcc;
                WriteToRobot(sPC_Command,sPC_ipccommandval);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void StartReading()
        {
			try 
            {
                while (!shouldStopReading)
                { 
                    if (serialPort.IsOpen && serialPort.BytesToRead > 0)
                    {
                        int bytesToRead = serialPort.BytesToRead;
                        byte[] buffer = new byte[bytesToRead];
                        int bytesRead = serialPort.Read(buffer, 0, bytesToRead);

                        int countZero = 0;
                        bool ch03 = false;
                        if (buffer.Length == 256)
                        {
                            for (int i = 0; i < buffer.Length - 1; i++)
                            {
                                if (buffer[i] == 0x00)
                                {
                                    countZero++;
                                }
                                if (buffer[255] == 0x03 && countZero == 255)
                                {
                                    ch03 = true;
                                    break;
                                }
                            }
                        }
                        if(countZero == 255 && ch03)
						{
                            sharedData.SharedVariable = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        }
                        else
						{
							if (buffer[0] != 0x00 && buffer.Length > 1)
							{
                                sharedData.SharedVariable = System.Text.Encoding.Default.GetString(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
			{
                string error = ex.Message;
                shouldStopReading = true;
                AutoRestart();
            }
        }

        private void AutoRestart()
		{
            shouldStopReading = false;
            backupThread = new Thread(new ThreadStart(StartReading));
            backupThread.IsBackground = true;
            Thread.Sleep(20);
            backupThread.Start();
        }

        private void btn_ServoOn_Click(object sender, EventArgs e)
        {
            btn_ServoOff.Enabled = true;
            btn_ServoOn.Enabled = false;
            ushort mask = SFrames.CommandoEnableZonaScarico;
            frame |= mask; // Ustawienie wskazanych bitów na 1
        }

        private void btn_ServoOff_Click(object sender, EventArgs e)
        {
            btn_ServoOn.Enabled = true;
            btn_ServoOff.Enabled = false;

            ushort number = 0x1001; // Liczba szesnastkowa 0x1234
            int shiftedNumber = number << 2;
            ushort result = (ushort)shiftedNumber;  // przesunięcie o 2 bity w lewo
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            // Zamknięcie portu szeregowego i zakończenie wątków
            shouldStopReading = true;
            serialPort.Close();
            if(sendThread != null && sendThread.IsAlive)
			{
                sendThread.Join();
            }
            if(readFromport != null && readFromport.IsAlive)
            {
                readFromport.Join();
            }
            if(backupThread != null && backupThread.IsAlive)
			{
                backupThread.Join();
            }
                
        }

        public void UpdateTextBox(string data)
        {
            // Sprawdź, czy wymagane jest wywołanie przez delegata
            if (rtb_AlarmField.InvokeRequired)
            {
                // Użyj delegata i metody Invoke, aby zaktualizować pole tekstowe
                rtb_AlarmField.Invoke(new Action(() => rtb_AlarmField.AppendText(data + Environment.NewLine)));
            }
            else
            {
                rtb_AlarmField.AppendText(data + Environment.NewLine);
            }
        }

		public void btn_RestartRead_Click(object sender, EventArgs e)
		{
            AutoRestart();
        }

        
       

        // Funkcja odczytu danych z robota
        private string ReadFromRobot(string cmd_to_send)
        {
            string sResult = string.Empty;
            if(!String.IsNullOrEmpty(sharedData.SharedVariable))
			{
                string ss = "555";
			}
            //  _CommSendString(cmd_to_send); // Wysyłanie komendy do robota

            //// Oczekiwanie na odpowiedź i odczytanie wartości
            //if (_CommReadString(ref sResult))
            //{
            //	// Sprawdzenie, czy otrzymana wartość jest poprawna
            //	if (sResult.StartsWith(sOK))
            //	{
            //		sResult = sResult.Replace(sOK, string.Empty).Trim();
            //		WriteToRobot(sOK); // Wysłanie potwierdzenia odbioru danych do robota
            //	}
            //	else
            //	{
            //		// Obsługa błędu odpowiedzi
            //		sResult = string.Empty;
            //	}
            //}
            //else
            //{
            //	// Obsługa błędu odczytu
            //	sResult = string.Empty;
            //}

            return sResult;
        }

        // Funkcja odczytu statusu systemu robota
        public void ReadRobotSystemStatus()
        {
            CLearBuffor();
            string sendingdata = robotCommunicationSend.SendData(sSF); // Wysyłanie komendy do robota
            Thread.Sleep(4000);

            string resultFromPort = sharedData.SharedVariable;
            if(resultFromPort.Contains("\u0003"))
			{
                CLearBuffor();
                robotCommunicationSend.SendData(sOK);
            }
            else
			{
                UpdateTextBox("\x09" + "ReadRobotSystemStatus" + "\x09" + sSF + "\x09");
            }
        }

		private void btn_speedUp_Click(object sender, EventArgs e)
		{
            string sPC_Command = "\x02MW, 1 PCSPEED 0 ";
            int sPC_ipccommandval = 0x01;
            WriteToRobot(sPC_Command, sPC_ipccommandval);
        }

		// Funkcja wysyłania komend do robota
		public void WriteToRobot(string cmd_to_send, int valToSend)
        {
            CLearBuffor();
            string fullCommand = cmd_to_send + valToSend.ToString()+ "\x03"; // Tworzenie pełnej komendy
            string sendingdata = robotCommunicationSend.SendData(fullCommand); // Wysyłanie komendy do robota
            
            Thread.Sleep(4000);
            string resultFromPort = sharedData.SharedVariable;
            if (string.IsNullOrEmpty(resultFromPort))
            {
                return;
            }
            if(cmd_to_send != sOK)
			{
                if(resultFromPort.Contains("\x03"))
				{
                    string getDataFromString = resultFromPort.Substring(resultFromPort.IndexOf("\x03"), resultFromPort.Length);
                    if (getDataFromString.Contains("OK"))
                    {
                        //zwrócono prawidlowa wartosc
                    }
                    else
                    {
                        UpdateTextBox("\x09" + "WriteToRobot" + "\x09" + cmd_to_send + "\x09");
                    }
                }
            }
            else
			{
                //co jezeli zawiera?
            }
        }
        private void CLearBuffor()
		{
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
        }
    }
}
