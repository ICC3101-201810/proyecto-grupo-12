using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WindowsFormsApp3
{
    [Serializable]
    public class Usuario
    {
        public string uId, contra;
        public bool logedin;

        public Usuario(string uId, string contra, bool logedin)
        {
            this.uId = uId;
            this.contra = contra;
            this.logedin = logedin;
        }
    }
}
