using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace laboratorio_8
{
    [Serializable]
    class Local
    {
        string name, rut, horario;
        int i = 0,z=0,y=0,w=0;
        public Local()
        {

        }
        public Local(string aname, string arut, string ahorario)
        {
            name = aname;
            rut = arut;
            horario = ahorario;
        }

        public List<Tienda> tiendas = new List<Tienda>();
        public List<Restaurantes> restaurantes = new List<Restaurantes>();
        public List<Cine> cines = new List<Cine>();
        public List<Recreacional> recreacionals = new List<Recreacional>();
        public List<Tienda> tiendas2 = new List<Tienda>();
        public List<Restaurantes> restaurantes2 = new List<Restaurantes>();
        public List<Cine> cines2 = new List<Cine>();
        public List<Recreacional> recreacionals2 = new List<Recreacional>();
        public List<string> total = new List<string>();

        public void addlocaltienda(Tienda tienda)
        {
            tiendas.Add(tienda);
            i += 1;
            
        }
        public void addlocalRest(Restaurantes rest)
        {
            restaurantes.Add(rest);
            y += 1;
        }
        public void addlocalcine(Cine cine)
        {
            cines.Add(cine);
            z += 1;
        }
        public void addlocalre(Recreacional rec)
        {
            recreacionals.Add(rec);
            w += 1;
        }


        public static void creararchivo()
        {
            IFormatter archivo = new BinaryFormatter();
            Stream bf = new FileStream("Locales.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            bf.Close();
        }
        public void saveempresa()
        {
            IFormatter locales = new BinaryFormatter();
            Stream bf = new FileStream("Locales.bin", FileMode.Open, FileAccess.Write, FileShare.None);
       
            for (int q = 0; q < i; q++)
            {
                locales.Serialize(bf, tiendas[q]);

            }

            for (int q = 0; q < y; q++)
            {
                locales.Serialize(bf, restaurantes[q]);

            }

            for (int q = 0; q < z; q++)
            {
                locales.Serialize(bf, cines[q]);

            }

            for (int q = 0; q < w; q++)
            {
                locales.Serialize(bf, recreacionals[q]);

            }
            bf.Close();
        }
        public  void readempresa2()
        {
            IFormatter locales = new BinaryFormatter();
            Stream bf = new FileStream("Locales.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            for (int q = 0; q < i; q++)
            {
                Tienda tienda = (Tienda)locales.Deserialize(bf);
                tiendas2.Add(tienda);
                total.Add(tienda.infotienda());
                

            }
            for (int q = 0; q < y; q++)
            {
                Restaurantes rest = (Restaurantes)locales.Deserialize(bf);
                restaurantes2.Add(rest);
                total.Add(rest.inforestaurante());

            }
            for (int q = 0; q < z; q++)
            {
                Cine cine = (Cine)locales.Deserialize(bf);
                cines2.Add(cine);
                total.Add(cine.infocine());
            }
            for (int q = 0; q < w; q++)
            {
                Recreacional rec = (Recreacional)locales.Deserialize(bf);
                recreacionals2.Add(rec);
                Console.WriteLine(rec.inforecreacional());
                total.Add(rec.inforecreacional());
            }




            bf.Close();
        }
        public void readempresa()
        {
 
            for(int q=0; q < i; q++)
            {
                total.Add(tiendas[q].infotienda());
            }
            for (int q = 0; q < y; q++)
            {
                total.Add(restaurantes[q].inforestaurante());
            }
            for (int q = 0; q < z; q++)
            {
                total.Add(cines[q].infocine());
            }
            for (int q = 0; q < w; q++)
            {
                total.Add(recreacionals[q].inforecreacional());
            }




            






        }
        
        
    }
}
