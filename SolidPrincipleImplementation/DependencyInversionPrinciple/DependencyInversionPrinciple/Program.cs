using System;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D: Dependency Inversion Principle (DIP)!");
            Console.ReadLine();
        }
    }
}


/*D in SOLID stands for Dependency Inversion Principle which is also known as DIP.

The Dependency Inversion Principle states that:   

High-level modules should not depend on low-level modules. Both should depend on 
abstractions.
AND
Abstractions should not depend on details. Details should depend on 
abstractions.

To simplify this we can state that while designing the interaction between 
a high-level module and a low-level one, the interaction should be thought of 
as an abstract interaction between them.*/


// High-level Module depends directly on Low-level Module:

/*public class BusinessLogicLayer
{
    private readonly DataAccessLayer DAL;

    public BusinessLogicLayer()
    {
        DAL = new DataAccessLayer();
    }

    public void Save(Object details)
    {
        DAL.Save(details);
    }
}

public class DataAccessLayer
{
    public void Save(Object details)
    {
        //perform save
    }
}*/


/*The high-level class defines its own adapter interface which is the
abstraction that the other high-level classes depend on.

Adapter Design pattern can be seen as an example which is applying the
dependency inversion principle.*/

/*public class BusinessLogicLayer
{
    private readonly IRepositoryLayer DAL;

    public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
    {
        DAL = repositoryLayer;
    }

    public void Save(Object details)
    {
        DAL.Save(details);
    }
}

public interface IRepositoryLayer
{
    void Save(Object details);
}

public class DataAccessLayer : IRepositoryLayer
{
    public void Save(Object details)
    {
        //perform save
    }
}*/