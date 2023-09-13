using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Delfino : Animale, INuotante, IAzione

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
            Console.WriteLine("Io Mangio il granchio blu");
        }
        public override void Verso()
        {
            Console.WriteLine("il mio verso e': Hic! Hic!");
        }
public void Nuota()
        {
            Console.WriteLine("Io posso Nuotare!");
        }

       public void Vola()
        {
            Console.WriteLine("I delfini nooooon vooolano");
        }
    }
}

