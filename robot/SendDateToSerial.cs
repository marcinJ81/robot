using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace robot
{
	public class SendDateToSerial
	{
        private SerialPort serialPort;
        private string infoToShow;
        public SendDateToSerial(SerialPort serialPortToSend)
		{
            serialPort = serialPortToSend;
        }
        public string SendData(object valueForSend)
        {
            int iterations = 1; // Liczba iteracji do wysłania
            int sentIterations = 0; // Licznik wysłanych iteracji
            if (valueForSend == null)
            {
                return string.Empty;
            }
            string textForSend = (string)valueForSend;
            while (sentIterations < iterations)
            {
                // Wątek wysyłający dane
                if (serialPort.IsOpen)
                {
                    // Generowanie losowej wartości 16-bitowej
                    //ushort value = (ushort)new Random().Next(0, ushort.MaxValue);
                    byte[] buffer = Encoding.UTF8.GetBytes(textForSend);
                    // Konwersja wartości na tablicę bajtów


                    // Wysłanie danych
                    serialPort.Write(buffer, 0, buffer.Length);

                    // Aktualizacja interfejsu użytkownika z innego wątku\\
                    string infoToShow = BitConverter.ToString(buffer);
                    string infoToShowEncoding = Encoding.ASCII.GetString(buffer);
                  
                    sentIterations++;
                }
               
            }
            return infoToShow;
        }
    }
}
