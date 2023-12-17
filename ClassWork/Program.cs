using ClassWork.Models;

Person person1 = new();
person1.Age = 20;
Person person2 = new();
person2.Age = 70;
Person person3 = new();
person3.Age = 50;

Person[] people = {person1, person2, person3};
    for (int j = 0; j < people.Length-1; j++)
    {
        
        if (people[j] > people[j + 1])
        {
            Person temp = people[j];
            people[j] = people[j + 1];
            people[j + 1] = temp;
        }
    }

foreach (Person item in people)
{
    Console.WriteLine($"Age: {item.Age}");
}