using System;

class Program
{
    //interface newlenemez
    static void Main(string[] args)
    {
        IPersonManager customerManager = new CustomerManager();
        

        IPersonManager employeeManager = new EmployeeManager();
        
        ProjectManager projectManager = new ProjectManager();

        projectManager.Add(customerManager);

    }
}

interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
    
}
//interface de içi boş methodu eklemek zorunda içini farklı doldurabilir
//inherits - class -------- implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");

    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //çalışan ekleme kkodları
        Console.WriteLine("Çalışan eklendi");

    }

    public void Update()
    {
        Console.WriteLine("Çalışan güncellendi");

    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    
}