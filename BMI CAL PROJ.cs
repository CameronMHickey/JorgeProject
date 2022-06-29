using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_CAL_PROJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

			//declaired ariables
			int weight;
			int height;
			int bmi;


			Console.WriteLine("Please Enter your height in inches: "); //Asks user for their height 
			height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter your weight in pounds: "); //Asks user for their weight 
			weight = Convert.ToInt32(Console.ReadLine());


			bmi = (weight * 703) / (height * height); //Actual BMI calculation

			if (bmi >= 18 && bmi <= 30) //Tests the users input, tells the user what their BMI is 
			{

				Console.WriteLine("Your BMI is {0}. Please follow the chart below to see if you are underweight, normal, overweight or obese.", bmi);   //Tells user BMI score and provides the chart to display the information

				Console.WriteLine("\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater.");
			}


		}
    }
}


// https://www.cdc.gov/obesity/basics/adult-defining.html#:~:text=If%20your%20BMI%20is%20less,falls%20within%20the%20obesity%20range.
