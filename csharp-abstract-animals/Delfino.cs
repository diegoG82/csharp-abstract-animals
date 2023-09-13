using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Delfino : Animale

    {
        public Delfino(string name) : base(name)
        {
            this.name = name;
        }

        public override void Dormi()
        {
            Console.WriteLine("Io sono il delfino che dorme");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("mangio il granchio blu");
        }
        public override void Verso()
        {
            Console.WriteLine("Hic! Hic!");
        }

    }
}

