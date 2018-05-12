using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WindowsFormsApp3
{
    [Serializable]
    public class Persona : Usuario
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

        public void AgregarUsuarioP (Persona p, List<Persona> ps)
        {
            ps.Add(p);
            usuariosP.Add(p);
            
        }

        public void LogIn (Persona usu, List<Persona> ps)
        {
            if (ps == null)
            {

            }
            else
            {
                foreach (Persona p in ps)
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

        public void LogOut(List<Persona> ps)
        {
            foreach (Persona p in ps)
            {
                if (p.logedin == true)
                {
                    p.logedin = false;
                }
            }
        }

        public void ListasUsuarios(List<Persona> ps)
        {
            usuariosP = ps;
        }

        public List<Persona> GetListaUsuarios()
        {
            return usuariosP;
        }

        public Persona GetPersona(string uId, List<Persona> p)
        {
            foreach (Persona per in p)
            {
                if (per.uId == uId)
                {
                    return per;
                }
            }
            return null;
        }
    }
}
