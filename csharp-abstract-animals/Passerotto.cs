namespace csharp_abstract_animals
{

    class Passerotto : Animale, IVolante

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
        public void Vola()
        {
            Console.WriteLine("Sto volando come un passerotto molto fiero!");
        }

    }
}

