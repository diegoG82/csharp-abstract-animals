namespace csharp_abstract_animals
{
    //CREAZIONE CLASSE ASTRATTA
    abstract class Animale
    {

        protected string name;

        public Animale(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        public abstract void Dormi();
        public abstract void Verso();
        public abstract void CosaMangi();

    }
}
