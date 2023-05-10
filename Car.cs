using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Cars_9d
{
    internal class Car
    {
        public string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value;}
        }

        public string model;
        public string Model
        {
            get { return  model; }
            set { model = value; }
        }

        public string registrnum;
        public string Registrnum
        {
            get { return registrnum; }
            set { registrnum = value; }
        }

        public int god;
        public int God
        {
            get { return god; }
            set { god = value; }
        }

        public Car(string brand, string model, string rigistrnum, int god) 
        {
            this.brand = brand;
            this.model = model;
            this.registrnum = rigistrnum;
            this.god = god;
        } 
        //metodi
        public void dvijenie()
        {
            Console.WriteLine($"{brand}, {model} brum-brum-brum");
        }
        public void ECOstatus()
        {
            if (god>2000)
            {
                Console.WriteLine("ECO");
            }
            else
            {
                Console.WriteLine("ne sum ECO pushi qko");
            }

        }
        public void Info()
        {
            Console.WriteLine($"{brand}, {model}, {registrnum}, {god}");
        }
       
    }
}
