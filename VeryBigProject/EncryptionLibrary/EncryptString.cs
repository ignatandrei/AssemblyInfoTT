using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLibrary
{
    public class EncryptString
    {
        public string Encrypt(string x)
        {
            return string.Join("",x.Reverse());
        }
    }
}
