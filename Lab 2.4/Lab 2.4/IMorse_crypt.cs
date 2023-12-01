using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_stud
{
    //Define interface IMorse_crypt wicth two methods  
    //crypt - to crypt the string
    //decrypt - to decrypt array of strings

    interface IMorse_crypt
    {
        public string crypt(string word);
        public string decrypt(string[] signals);
    }
}
