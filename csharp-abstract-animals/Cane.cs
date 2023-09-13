namespace csharp_abstract_animals
{
    class Cane : Animale, INuotante, IAzione

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
            Console.WriteLine("Il mio verso e': Bau! Bau!");
        }

        public void Nuota()
        {
            Console.WriteLine("Io posso Nuotare!");
        }

        public void Vola()
        {
            Console.WriteLine("I cani non volano ahime'");
        }

    }
}