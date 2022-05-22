// See https://aka.ms/new-console-template for more information
internal abstract class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public int NoOfLegs { get; set; }
    public bool Tail { get; set; }

    public abstract string DoSound();

    public Animal(string name, double weight, int age, int noOfLegs, bool tail) //varför blir det fel när man skapar konstruktorn med parametrar?
    {
        Name = name;    
        Weight = weight;    
        Age = age;  
        NoOfLegs = noOfLegs;    
        Tail = tail;    

    }
    public virtual string Stats()
    {
        string hasTail = ""; 
        if (Tail == true)
        {
            hasTail = "Ja"; 
        }
        else
        {
            hasTail = "Nej"; 
        }
        return $"Namn: {Name}, Ålder: {Age}, Vikt: {Weight}, Antal ben: {NoOfLegs}, Har svans: {hasTail}"; 
    }
}