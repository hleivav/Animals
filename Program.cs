// See https://aka.ms/new-console-template for more information

//********************************************
// Svar på fråga 3.2) ARV - 13
// Attributen bör finnas i klassen "Bird". 

// Svar på fråga 3.2) ARV - 14
// Attributen bör finnas i klassen "Animal".
//********************************************



using Animals;
//Skapar en lista av animals
List<Animal> listAnimals = new List<Animal>() ;
//Skapar djur och lägger dem i listan.
Dog dog = new Dog("Fido", 24.5, 3, 4, true, "labradoodle");
listAnimals.Add(dog);   
Horse horse = new Horse("Legolas", 305, 2, 4, true, 50);
listAnimals.Add(horse);
Worm worm = new Worm("Bamse", 0.02, 1, 0, false, false);
listAnimals.Add(worm);
Bird bird = new Bird("Rupert", 0.2, 1, 2, false, 3000);
listAnimals.Add(bird);
Wolf wolf = new Wolf("Django", 42.5, 7, 4, true, 1.2);
listAnimals.Add(wolf);
Pelican pelican = new Pelican("Trolle", 12.4, 5, 2, false, 4000, 44.4);
listAnimals.Add(pelican);
Flamingo flamingo = new Flamingo("Rolle", 17, 6, 2, false, 4329, 2.7);
listAnimals.Add(flamingo); 
Swan swan = new Swan("Molle", 18.7, 2, 2, false, 3928, 76); 
listAnimals.Add(swan);
Wolfman wolfman = new Wolfman("Wolfie", 80, 40, 2, false); 
listAnimals.Add(wolfman);
Dog dog2 = new Dog("Alba", 24, 4, 4, true, "labradoodle");
listAnimals.Add(dog2); 


//Loopar igenon Animal listan
foreach(var animal in listAnimals)
{
    //skriv ut alla djur från listan
    Console.WriteLine(animal.Name);
    //anropa Sound() metoden för varje djur
    Console.WriteLine(animal.DoSound());

    //Ta reda på om djuret har interface Person och om så kasta till Person och anropa Talk()
    // hur vet man det?

    //Console.WriteLine("*****************");
    //var y = animal.GetType();
    //Console.WriteLine(typeof(y));
    //Console.WriteLine(typeof(IPerson).IsAssignableFrom(typeof(Wolfman))); 
    //Console.WriteLine("*****************");

    Console.WriteLine(animal.Stats());
    //******************Svar fråga 3.3.)Polymorfism - 13 S: Metoden Stats() finns i basklasen "Animals" och när den anropas från klasser som har den metoden
    // som basklass, exekveras metoden.
    
 
}


//Skapar en lista med bara hundar
List<Dog> listDogs = new List<Dog>() ; 
//Lägger till en hund i listan
listDogs.Add(dog);
//Försöker lägga till en häst i hundlistan
//listDogs.Add(horse);  **** Svar fråga 3.3)Polymorfism - 9 S: Det går inte att lägga ett djur av typ häst i en lista av klassen hundar.
//*********** Svar fråga 3.3)Polymorfism - 10 S: Alla djur kan lagras i en lista som består av basklassen "animals". 

// ny loop som  använder stats för att printa ut enbart hundar
foreach(var animal in listAnimals)
{
    if(animal.GetType() == typeof(Dog))
    {
        Console.WriteLine(animal.Stats());
        //************** Svar fråga 3.3)Polymorfism - 16 och 17 S: En klass härstammar från en Basklass kommer åt dennas metoder, dock inte tvärtom. 
        string x = ((Dog)animal).DogieTrick();
        Console.WriteLine(x);
    }
}