using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1.Clases
{
    class Controller
    {
        List<Director> directores = new List<Director>();
        List<Actor> actores = new List<Actor>();
        List<Productor> productores = new List<Productor>();

        public void Serializar()
        {
            BinaryFormatter serializador = new BinaryFormatter();
            Stream miStream = new FileStream("Directores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador.Serialize(miStream, directores);
            miStream.Close();

            BinaryFormatter serializador2 = new BinaryFormatter();
            Stream miStream2 = new FileStream("Actores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador2.Serialize(miStream2, actores);
            miStream2.Close();

            BinaryFormatter serializador3 = new BinaryFormatter();
            Stream miStream3 = new FileStream("Productores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador3.Serialize(miStream3, productores);
            miStream3.Close();
        }

        public void Deserializar()
        {
            BinaryFormatter serializador = new BinaryFormatter();
            Stream miStream = new FileStream("Directores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            directores = (List<Director>)serializador.Deserialize(miStream);
            miStream.Close();

            BinaryFormatter serializador2 = new BinaryFormatter();
            Stream miStream2 = new FileStream("Actores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            actores = (List<Actor>)serializador2.Deserialize(miStream2);
            miStream2.Close();

            BinaryFormatter serializador3 = new BinaryFormatter();
            Stream miStream3 = new FileStream("Productores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            productores = (List<Productor>)serializador3.Deserialize(miStream3);
            miStream3.Close();
        }
    }
}
