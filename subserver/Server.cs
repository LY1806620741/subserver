using System;
using System.Collections.Generic;
using System.Text;

namespace subserver.controller
{
    class Server
    {

        public System.Net.IPAddress[] GetIP()
        {
            string hostName = System.Net.Dns.GetHostName();
            //hostName获取主机名称
            System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(hostName);//Dns.GetHostByName(hostName);
                                                                                   //ip地址列表
            return  ipEntry.AddressList;
        }
    }
}
