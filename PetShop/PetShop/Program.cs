using PetShop.Petshop;

Pet pet1 = new Pet("Pepita", 16, "cachorro", "Vira-Lata");
Pet pet2 = new Pet("Peralta", 4, "gato", "Angorá");
Pet pet3 = new Pet("Kenai", 15, "cachorro", "Bichon Frisé");

List<Pet> pets = new();
pets.Add(pet1);
pets.Add(pet2);
pets.Add(pet3);

foreach (Pet pet in pets)
    Console.WriteLine($"Pets: { pet.Nome}, {pet.Idade} anos, {pet.Tipo}, {pet.Raca}");

Dono dono1 = new Dono("Márcia", "Cid Moreira");
Dono dono2 = new Dono("Vitória", "São Miguel");
Dono dono3 = new Dono("Vera", "Centro");
