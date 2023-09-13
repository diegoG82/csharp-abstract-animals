

using csharp_abstract_animals;

//CREO ANIMALI
Aquila aquila = new ("Thunder");
Cane cane = new ("Turbo");
Delfino delfino = new("Willy");
Passerotto passerotto = new("Geltrude");

//CREO UNA LISTA CON I MIEI ANIMALI E LI AGGIUNGO AD ESSA
List<Animale> animali = new List<Animale>();

animali.Add(aquila);
animali.Add(cane);
animali.Add(delfino);
animali.Add(passerotto);

//CICLO LA SLISTA CREATA CON I MIEI ANIMALI
foreach (Animale animaleZoo in animali)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Io sono una {animaleZoo.GetType().Name} e mi chiamo {animaleZoo.GetName()}");
    animaleZoo.CosaMangi();
    animaleZoo.Verso();
    animaleZoo.Dormi();
    Console.WriteLine("-----------------------");
}





