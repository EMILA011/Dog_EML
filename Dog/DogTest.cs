/**
 * This class tests the Dog class.
 * @author Elena Milan Lopez
 * @version 1.0
 * Project 1 -Solution
 * SP20
 */

using System;

namespace Dog
{
     class DogTest
     {
          static void Main(string[] args)
          {

               Dog dog1 = new Dog();
               Dog dog2 = new Dog(5,"Tommy");
             
               
               
               dog1.setAge(7);
               dog1.setName("Pepe");
             
               Console.WriteLine("Dog1 name is: " + dog1.getName() + " and Dog2  name is:" + dog2.getName());
               Console.WriteLine("Dog1 age is: " + dog1.getAge()  + " and Dog2  age is:" + dog2.getAge());
               
               Console.WriteLine("Dog1 is: " + dog1.calcDogYears() + " years old.");
               Console.WriteLine("Dog2 is: " + dog2.calcDogYears() + " years old.");
               
               Console.WriteLine(dog1.toString());
               Console.WriteLine(dog2.toString());
         
          }
     }
}
