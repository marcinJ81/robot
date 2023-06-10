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
        public string SendData(string valueForSend)
        {
            // Wątek wysyłający dane
            if (serialPort.IsOpen)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(valueForSend);
                // Konwersja wartości na tablicę bajtów
                // Wysłanie danych
                serialPort.Write(buffer, 0, buffer.Length);
                infoToShow = Encoding.ASCII.GetString(buffer);
            }
            return infoToShow;
        }
    }
}
