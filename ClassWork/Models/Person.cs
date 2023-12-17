namespace ClassWork.Models;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public static bool operator >(Person p1, Person p2)
    {
        return p1.Age > p2.Age;
    }
    public static int operator -(Person p1, Person p2)
    {
        return p1.Age-p2.Age;
    }
    public static int operator +(Person p1, Person p2)
    {
        return p1.Age+p2.Age;
    }
    public static bool operator <(Person p1, Person p2)
    {
        return (p1.Age < p2.Age);
    }
}
