namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        //Step 1
        //Allen Au IT 1050 Lab1
        //Step 2
    Console Write.Line("Allen Au IT 1050") 
        //Step 3
    int favorite = 3;   
    Console WriteLine("My favorite number is" + favorite);
    string programminglanguage = "Python";     
    Console.WriteLine("My favorite programming language is" + programminglanguage);   
    double numberofprogramminglanguages = 1;
    Console.WriteLine("The number of programs I've written before this is" + numberofprogramminglanguages);
    bool experience = true;
    Console.WriteLine("I have programming experience" + experience);  
        //Step 4
    const string schoolName = "Tri-C"; 
    Console.WriteLine("My school name is:" + schoolName);   
        //Step 5
    double myDouble = 9.78;
    int myInt = (int)myDouble;
    bool myBool = true;
    Console.WriteLine(Convert.ToString(myInt));
    Console.WriteLine(Convert.ToString(myBool));
        //Step 6
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();
    Console.WriteLine("Username is" + username);
    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age is:" + age);
    Console.WriteLine("Hello" + username! + "You are age years old"); 
        //Step 7
    int num1 = 10;
    int num2 = 20;
    Console.WriteLine(num1 + 10); //20
    Console.WriteLine(num2 + 10); //30
    Console.WriteLine(num1 - 2);  //8
    Console.WriteLine(num2 - 2);  //18
    Console.WriteLine(num1 * 3);  //30
    Console.WriteLine(num2 * 3);  //60
    Console.WriteLine(num1 / 2);  //5
    Console.WriteLine(num2 / 2);  //10
    Console.WriteLine(num1 % 2);  //0
    Console.WriteLine(num2 % 2);  //0
        //Step 8
    float myFloat = 1.123456789f;
    double myDouble = 1.123456789d;
    Console.WriteLine(myFloat);
    Console.WriteLine(myDouble);    
    //Double variable offers more precision with the decimal numbers
        //Step 9
     int num = 10;
    Console.WriteLine(++num); //11
    Console.WriteLine(--num); //9   
        
        }
