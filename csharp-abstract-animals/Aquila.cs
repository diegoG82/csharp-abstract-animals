using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

        class Aquila : Animale

        {
            public Aquila(string name) : base(name)
            {
                this.name = name;
            }

            public override void Dormi()
            {
                Console.WriteLine("Io sono l'aquila che dorme");
            }

            public override void CosaMangi()
            {
                Console.WriteLine("Io mangio barboncini!");
            }

            public override void Verso()
            {
                Console.WriteLine("Chow Chow!!");
            }

        }
    }

