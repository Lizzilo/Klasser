using klasser;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person person1;
        person1 = new Person();
        Person person2= new Person();
        Person person3= new Person("Liza" , "Odish", 123456789);

        person1.setname("Milo");
        person1.setlastname("Plupp");
        person1.setperson_nr(2001012);
        Console.WriteLine(person3.getname());
        Console.WriteLine(person3.ToString());
    }
}