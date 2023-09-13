namespace csharp_abstract_animals
{

    class Aquila : Animale, IVolante

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
            Console.WriteLine("Il mio verso e' Chow Chow!!");
        }

        public void Vola()
        {
            Console.WriteLine("Io posso volare come un'aquila cazzutissima!");
        }

    }
}

