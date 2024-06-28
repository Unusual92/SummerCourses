using System;
using System.Linq;
using System.Collections.Generic;


public interface IAnimal
{
    string Name { get; } 
    void Noise(); 
}


public class Herbivore : IAnimal
{
    public string Name { get; } 

    public Herbivore(string name)
    {
        Name = name;
    }

    public void Noise()
    {
        Console.WriteLine("тутуту");
    }
}


public class Carnivore : IAnimal
{
    public string Name { get; }

    public Carnivore(string name)
    {
        Name = name;
    }

    public void Action(Herbivore herbivore, List<IAnimal> herbivores)
    {
       Console.WriteLine($"{Name} съел {herbivore.Name}");
       herbivores.Remove(herbivore);
    }

    public void Noise()
    {
        Console.WriteLine("Ррррр");
    }
}

public class Program
{
    public static void Main()
    {
        Herbivore bird = new Herbivore("Аркаша");
		Herbivore hare = new Herbivore("Шрек");
        Carnivore tiger = new Carnivore("Мурзик");
        Carnivore dog = new Carnivore("Мара");
       

        List<IAnimal> carnivores = new List<IAnimal> { tiger, dog };
        List<IAnimal> herbivores = new List<IAnimal> { bird, hare };

  
        ((Carnivore)carnivores.OrderBy(a => Guid.NewGuid()).First()).Action((Herbivore)herbivores.OrderBy(a => Guid.NewGuid()).First(), herbivores);


        foreach (var animal in herbivores)
        {
            Console.WriteLine($"{animal.Name} звук:");
            animal.Noise();
        }
        foreach (var animal in carnivores)
        {
            Console.WriteLine($"{animal.Name}  звук:");
            animal.Noise();
        }
    }
}
