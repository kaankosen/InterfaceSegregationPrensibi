using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrensibi
{
    internal class InterfaceSegregationPrensibiDogru
    {

        public interface Kosmak
        {
            void Kos();
        }

        public interface Ucmak
        {
            void Uc();
        }
        public interface Kukremek
        {
            void Kukre();
        }


        public class Kus : Kosmak, Ucmak
        {
            public void Kos()
            {
                Console.WriteLine("Kuşlar koşabilir");
            }
            public void Uc()
            {
                Console.WriteLine("Kuşlar uçabilir");
            }
        }

        public class Aslan : Kukremek, Kosmak
        {
            public void Kukre()
            {
                Console.WriteLine("Aslanlar kükreyebilir");
            }
            public void Kos()
            {
                Console.WriteLine("Aslanlar koşabilir");
            }
        }


    }
}
