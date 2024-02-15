using System;
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(2,"Berk","Kıyı","Kocaeli");
        Console.WriteLine(customer.LastName);

    }
}

class Customer
{
    //default constructor
    public Customer(int id,string firstName,string lastName,string city)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.City= city;
        this.Id= id;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}