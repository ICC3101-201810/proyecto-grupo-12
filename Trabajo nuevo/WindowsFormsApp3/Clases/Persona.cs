using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class Persona : Usuario
    {
        public string nombre, mail, carrera, numero;
        public enum Ocupacion { Administrador, Usuario };
        public Ocupacion ocupacion;
        public List<Persona> usuariosP { get; set; }

        public Persona(string nombre, string mail, string carrera, string numero, Ocupacion ocupacion, string uId, string contra, bool logedin) : base(uId, contra, logedin)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.carrera = carrera;
            this.numero = numero;
            this.ocupacion = ocupacion;
        }

        public void AgregarUsuarioP (Persona p)
        {
            usuariosP.Add(p);
            
        }

        public void LogIn (Persona usu)
        {
            if (usuariosP == null)
            {

            }
            else
            {
                foreach (Persona p in usuariosP)
                {
                    if (usu.nombre == p.nombre)
                    {
                        if (usu.contra == p.contra)
                        {
                            p.logedin = true;
                            usu = p;
                        }
                    }
                }
            }
        }

        public void LogOut()
        {
            foreach (Persona p in usuariosP)
            {
                if (p.logedin == true)
                {
                    p.logedin = false;
                }
            }
        }

        public List<Persona> GetListaUsuarios()
        {
            return usuariosP;
        }
    }
}
