namespace csharp_abstract_animals
{
    class Cane : Animale

    {
        public Cane(string name) : base(name)
        {
            this.name = name;
        }

        public override void Dormi()
        {
            Console.WriteLine("Io sono il cane che dorme");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Io mangio crocchette");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau Bau");
        }

    }
}