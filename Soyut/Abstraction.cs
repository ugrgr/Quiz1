using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut
{
    internal class Abstraction
    {
        public abstract class MobilePhone
        {
            public string Calling()
            {
                return "Phone Calling";
            }
            public string SendSMS()
            {
                return "Sending SMS";
            }
        }
    
        public class Nokia2700 : MobilePhone
        {
            public string FMRadio()
            {
                return "FMRadio Openning";
            }
            public string MP3()
            {
                return "Mp3 Player";
            }
            public string Camera()
            {
                return "TAke Photo";
            }
        }
        public class BlackBerry : MobilePhone
        {
            public string FMRadio()
            {
                return "FMRadio Openning";
            }
            public string MP3()
            {
                return "Mp3 Player";
            }
            public string Camera()
            {
                return "Take Photo";
            }
            public string Recording()
            {
                return "Recording";
            }
            public string ReadAndSendEmails()
            {
                return "Mail";
            }
        }
    }
}
