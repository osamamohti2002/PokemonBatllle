using System;



public class Getname
{
    public string name;


    public Getname(string Name)
    {
        this.name = Name;
    }

}


class Program
{
    static void Main(string[] args)
    {
        Getname myName = new Getname("Lithe");
        Console.WriteLine(myName);
    }
}

