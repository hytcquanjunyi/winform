using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;


namespace hytc.ChatRomUDP
{
    public class Operation
    {
        mainForm _mf;
        public Operation()
        {
          
        }
         public Operation(mainForm mf) 
        {
            _mf = mf;
        }

         public IPAddress getMyIP() {

             IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
             foreach(IPAddress ip in ips)
             {
                 if (ip.AddressFamily.ToString() == "InterNetwork") 
                 {
                     return ip;
                 }
             }
             return null;
         }
        public delegate void delegateAdd(Friend fr);
        public delegate void delegateRemove(Friend fr);
        public void receiver()
        {
            UdpClient client = new UdpClient(9527);

            while (true)
            {
                IPEndPoint iept = new IPEndPoint(IPAddress.Any, 0);

                byte[] msgbyte = client.Receive(ref iept);

                string msgstring = Encoding.Default.GetString(msgbyte);

                string[] split = msgstring.Split('|');
                Friend fr = new Friend();
                string cmd = split[0];
                switch (cmd)
                {
                    case "LOGIN":

                        if (split.Length!=4)
                        {
                            continue;
                        }
                        if (getMyIP().ToString()==iept.Address.ToString())
                        {
                            continue;
                        }
                        UCFriendUnit ucfriend = new UCFriendUnit();
                        fr.NikNme = split[1];
                        fr.ShouShou = split[3];
                        fr.PicIndex = Convert.ToInt32(split[2]);
                        fr.IP = iept.Address;

                  
                        object[] pars = new object[1];
                        pars[0] = fr;
                        _mf.Invoke(new delegateAdd(_mf. addUCFriendUnit), pars);
                        UdpClient also = new UdpClient();
                        string resopnse = "ALSOON|" + _mf.mynickName + "|0| 说薯片";
                        byte[] resopnsebyte = Encoding.Default.GetBytes(resopnse);
                        IPEndPoint ipet2 = new IPEndPoint(fr.IP, 9527);
                        also.Send(resopnsebyte, resopnsebyte.Length,ipet2);
                            break;
                    case "MSG":

                            break;
                    case "ALSOON":
                        UCFriendUnit ucfriend1 = new UCFriendUnit();
                        fr.NikNme = split[1];
                        fr.ShouShou = split[3];
                        fr.PicIndex = Convert.ToInt32(split[2]);
                        fr.IP = iept.Address;
                        object[] parss = new object[1];
                        parss[0] = fr;
                        _mf.Invoke(new delegateAdd(_mf. addUCFriendUnit), parss);
                            break;
                    default: 
                            break;
                }
               
            }

        }
    }
}
