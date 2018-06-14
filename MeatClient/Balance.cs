using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MeatClient
{
    class Balance
    {
        SerialPort port = new SerialPort();

        //端口名称
        string name = "com1";
        // 波特率
        int baudRate = 9600;
        // 数据位
        string dataBits = "";

        public Balance()
        { }

    }
}
