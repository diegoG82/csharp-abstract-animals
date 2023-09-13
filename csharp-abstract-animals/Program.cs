

using csharp_abstract_animals;

//CREO ANIMALI
Aquila aquila = new("Thunder");
Cane cane = new("Turbo");
Delfino delfino = new("Willy");
Passerotto passerotto = new("Geltrude");

//CREO UNA LISTA CON I MIEI ANIMALI E LI AGGIUNGO AD ESSA
List<Animale> animali = new List<Animale>();

animali.Add(aquila);
animali.Add(cane);
animali.Add(delfino);
animali.Add(passerotto);

//CICLO LA LISTA CREATA CON I MIEI ANIMALI
foreach (Animale animaleZoo in animali)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Io sono una {animaleZoo.GetType().Name} e mi chiamo {animaleZoo.GetName()}");
    animaleZoo.CosaMangi();
    animaleZoo.Verso();
    animaleZoo.Dormi();
    Console.WriteLine("-----------------------");
}
//TESTO LE INTERFACCE

//IVolare
aquila.Vola();
passerotto.Vola();


//INuotante
cane.Nuota();
delfino.Nuota();

//METODO PER FARE VOLARE
static void FaiVolare(IVolante animale)
{
    animale.Vola();
}

FaiVolare(passerotto);
FaiVolare(aquila);

//METODO PER FAR NUOTARE
static void FaiNuotare(INuotante animale)
{
    animale.Nuota();
}

FaiNuotare(cane);
FaiNuotare(delfino);



//CICLO I VOLANTI ED I NUOTANTI DIFFERENZIANDOLI
Console.WriteLine();

foreach (Animale animaleZoo in animali)

{
    if (animaleZoo is IVolante)
    {
        Console.WriteLine($"Io sono una {animaleZoo.GetType().Name} e mi chiamo {animaleZoo.GetName()} e posso volare!!!");
        Console.Write($"Il mio motto e' {Vola()}")
    }
    else
    {
        Console.WriteLine($"Io sono una {animaleZoo.GetType().Name} e mi chiamo {animaleZoo.GetName()} e posso nuotare!!!");
    }

}

