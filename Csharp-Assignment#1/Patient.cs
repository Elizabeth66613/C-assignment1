using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace Csharp_Assignment_1
{
    internal class Patient
    {
        private string firstName;
        private string lastName;
        private int weight;
        private int height;
        public int systolic;
        public int diastolic;


        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public Patient(string firstName, string lastName, int weight, int height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }
        
        public void Blood(int systolic, int diastolic)
        {
            if ((systolic < 120)&&(diastolic < 80))
            {
                Console.WriteLine("Normal pressure");
            }
            else if ((119 < systolic)&&(systolic < 130)&&(diastolic < 80))
            {
                Console.WriteLine("Elevated pressure");
            }
            else if (((129 < systolic)&&(systolic < 140))||((79 < diastolic)&&(diastolic < 90)))
            {
                Console.WriteLine("HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1");
            }
            else if (((139 < systolic) && (systolic < 180)) || ((89 < diastolic) && (diastolic < 120)))
            {
                Console.WriteLine("HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2");
            }
            else if ((180 < systolic) || (120 < diastolic))
            {
                Console.WriteLine("HYPERTENSIVE CRISIS (consult your doctor immediately)");
            }
            else
            {
                Console.WriteLine("Incorrect data entry");
            }

        }

        public double BMI(int weight, int height)
        {
            double heightm = (double)height / 100;
            double bmi = weight / (heightm*heightm);
            return bmi;
        }
       
        public void PatInfo(int systolic, int diastolic)
        {
            Console.WriteLine($"Full name: {firstName} {lastName} \n Weight: {weight} \n Height: {height}");
            Blood(systolic, diastolic) ;
            double curbmi = BMI(weight, height);
            Console.WriteLine(curbmi);
            if (curbmi >= 25.0)
            {
                Console.WriteLine("Overweight");
            }
            else if ((curbmi > 18.4)&&(curbmi < 25.0))
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Underweight");
            }


        }


    }//class
}//namespace
