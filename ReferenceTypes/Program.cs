using System;

class Program
{
    static void Main()
    {
        //// int,double,enum,boolean value types -> keepin in stack
        //int sayi1 = 10;
        //int sayi2 = 20;

        //sayi1 = sayi2;

        //sayi2 = 100;

        //Console.WriteLine("Sayi 1:" + sayi1);

        ////array, class,interface .. reference types -> keeps in heap, when using "new" keyword it allocates a memory from heap
        //int[] sayilar1 = new int[] { 1, 2, 3 };
        //int[] sayilar2 = new int[] { 10, 20, 30 };

        //sayilar1 = sayilar2;//sayilar 1 in adresini sayilar 2 adresi yap
        //sayilar2[0] = 1000;
        //Console.WriteLine("Sayılar1[0]:"+sayilar1[0]);

        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "Berk";

        person2 = person1;
        person1.FirstName = "Engin";

        Console.WriteLine(person2.FirstName);


        Customer customer = new Customer();
        customer.FirstName = "Ömer";
        customer.CreditCarNumber = "1234567890";
        Employee employee = new Employee();

        Person person3 = customer;
        customer.FirstName = "Ahmet";
        
        Console.WriteLine(((Customer)person3).CreditCarNumber);

        PersonManager personManager = new PersonManager();
        personManager.Add(employee);
    }
}

//base class : Person
class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}


class Customer:Person
{
    public string CreditCarNumber { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}