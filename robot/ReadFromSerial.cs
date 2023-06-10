using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace robot
{
	public class ReadFromSerial
	{
		private SerialPort serialPort;
		public ReadFromSerial(SerialPort serialPort)
		{
			this.serialPort = serialPort;
		}
	}
}
