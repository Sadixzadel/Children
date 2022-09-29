using System;

Children FirstChild = new Children();
Children SecondChild = new Children();

FirstChild.Print();         
SecondChild.Print();         

class Children
{
    public string name;
    public string surname;
    public int age;
    
    private void Enter()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter surname: ");
        surname = Console.ReadLine();
        Console.Write("Enter age: ");
        age = Console.ReadLine();
    }
    
    public void Print()
    {
        Console.WriteLine($"Name: {name} Surname: {surname} Age: {age}");
    }
}
