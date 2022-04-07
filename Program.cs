using System;

namespace Day1_C__Info
{
    public class student
{
    private int rollno, percentage;
   private string name;
    public student()
    {
        rollno=101;
        name="Tanmay";
        percentage=78;
    }
    public student(int rollno, string name, int percentage)
    {
        rollno =rollno;
        name =name;
        percentage =percentage;
    }
    public void display()
    {
        Console.WriteLine($"Info is:{rollno}/{name}/{percentage}");
    }
}

    class Program
    {
        

        static void Main(string[] args)
        {
        student student=new student();
            student.display();
          /* int a=10;
           float f=23.45f;
           double d= 56.677;
           string str ="Tanmay";
           System.Console.WriteLine("value of a ="+a);
           System.Console.WriteLine("value of f {0} , d={1}",f,d);
           System.Console.WriteLine($"a={a}, float ={f}, double={d}");
           System.Console.WriteLine(str);*/

          /* int Addition, substraction, multiplication, division;

           System.Console.WriteLine("Enter First number: ");
           int num1=Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Enter another Number");
           int num2=Convert.ToInt32(Console.ReadLine());

           Addition= num1 + num2;
           System.Console.WriteLine(Addition);

           substraction= num1 - num2;
           System.Console.WriteLine(substraction);

           multiplication= num1 * num2;
           System.Console.WriteLine(multiplication);

           division= num1/ num2;
           System.Console.WriteLine(division);*/

          /* System.Console.WriteLine("Enter Age");
           int age =Convert.ToInt32(Console.ReadLine());
           if(age>18)
           {
               System.Console.WriteLine("Valid for voting");
           }
           else{
               Console.WriteLine("Not valid for voting");
           }*/

         //Area of Rectangle  

        /*Console.WriteLine("Enter the Length of a Rectangle: ");

        int Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Breadth of a Rectangle: ");

        int Breadth = Convert.ToInt32(Console.ReadLine());
        int Area = Length * Breadth;

        Console.WriteLine($"Area of Length {Length} and Breadth {Breadth} Rectangle is {Area}");
        
        
        Console.ReadKey();*/



    //Sum of Even Number

       /* int i, num, sum = 0;
 
        
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());        
 
        for (i = 2; i <= num; i += 2)
        {
            
            sum += i;
        }
        Console.WriteLine("Sum of all even number between 1 to " + num + " = "+ sum);
 
        Console.ReadLine();*/


        //Even AND Odd Number Print

        /* int i     = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 45; i++)
            {   
                if( i%2 == 0 )
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();*/



// Check alphabet or digit,special character


        /*char ch;
 
        Console.WriteLine("Enter any character: ");
        ch = Convert.ToChar(Console.ReadLine());
 
        // Alphabet checking condition
        if ((ch >= 'a' && ch <= 'z') )
        {
            Console.WriteLine(ch + "is an LowerCase Alphabet. ");            
        }
        else if ((ch >='A' && ch <= 'Z') )
        {
            Console.WriteLine(ch + "is an UpperCase Alphabet");
        }
        else if (ch >= '0' && ch <= '9')
        {         
            Console.WriteLine(ch + "is a Digit. ");
        }
        else
        {
            Console.WriteLine(ch + "is a Special character.. ");            
        } 
 
        Console.ReadLine();*/


// Check LeapYear or not
        /* Console.WriteLine("Enter Year : ");  
            int Year = int.Parse(Console.ReadLine());  
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
             Console.WriteLine("{0} is a Leap Year.", Year);  
            else
             Console.WriteLine("{0} is not a Leap Year.", Year);  
            Console.ReadLine();*/


// Check Number +ve, -ve or Zero


        /*     int num;
 
        Console.WriteLine("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());        
 
        if (num > 0)
        {            
            Console.WriteLine("Enter number is positive ");
        }
        else if (num < 0)
        {
            Console.WriteLine("Enter number is nagative ");            
        }
        else
        {
            Console.WriteLine("Enter number is zero ");            
        }     
 
        Console.ReadLine();*/


// Weekdays Check using Switch case


       /* int day;
        
        Console.WriteLine("Enter the week day number : ");
		day = Convert.ToInt32(Console.ReadLine());
		
		switch(day){
			case 1:
				Console.WriteLine("Monday");
				break;
			case 2:
				Console.WriteLine("Tuesday");
				break;
			case 3:
				Console.WriteLine("Wednesday");
				break;
			case 4:
				Console.WriteLine("Thursday");
				break;
			case 5:
				Console.WriteLine("Friday");
				break;
			case 6:
				Console.WriteLine("Saturday");
				break;
			case 7:
				Console.WriteLine("Sunday");
				break;
			default:
				Console.WriteLine("Invalid input");
				break; 

        } */








           
        

        }
    }
    }
