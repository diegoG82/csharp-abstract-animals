using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

    class Passerotto : Animale

    {
        public Passerotto(string name) : base(name)
        {
            this.name = name;
        }

        public override void Dormi()
        {
            Console.WriteLine("Io sono il passerotto che dorme");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Io mangio i biscottini");
        }
        public override void Verso()
        {
            Console.WriteLine("Il mio verso è Pas! Pas!");
        }

    }
}

