/**
 * This class models a Dog.
 * @author Rob Kelley
 * @author Elena Milan Lopez
 * @version 1.0
 * Project 1 -Solution
 * SP20
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Dog
{
	public class Dog
	{

		private int age;
		private String name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.setAge(age);
			this.setName(name);

		}//end constructor

		public int calcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void setName(String name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();
			
			for (int i = 0; i < n.Length; i++)
			{
				if (!char.IsLetter(n[i]))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName

	     public String toString()
		{
			return "Dog [age=" + age + ", name=" + name + "]";
			
		}//end toString

	}//end class
}


