using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace hytc.ChatRomUDP
{
    public class Friend
    {
        public string NikNme { get;set;}
        public int PicIndex { get;set;}
        public string ShouShou { get;set;}
        public IPAddress IP { get; set;}
        public bool IsOpen { get; set;}
    }
}
