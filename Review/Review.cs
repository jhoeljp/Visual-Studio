using System;


//we are on the hippo project 
namespace Hippo
{
    //clas is a container where we can put code
    class Program
    {
        //everything in Main gets executed 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Hippo Hippo i__i ");
            //String input = Console.ReadLine();
            //for (int i=0; i<5; i++) {
            //    Console.WriteLine(input);
            //}


            //String name = "Jhoel";
            //int age = 25;
            //Console.WriteLine("there once was a man named " + name);
            //Console.WriteLine("He was " + age + " years old");
            //Console.WriteLine("He really liked the name " + name);
            //Console.WriteLine("But he really didn't like being " + age);

            //-----TYPES
            //string phrase = "Hippo Academy";
            //char grade = 'A';
            //int level = 9000;
            //float depth = 10.9;
            //double dous = 22.22;
            //decimal money = 1.00000234;
            //bool youSigma = true;

            //-----STRINGS
            //string phrase = "Hippo Academy";
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.Contains("Hippo"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.Split(" ")[1]);
            //Console.WriteLine(phrase.IndexOf('a'));
            //Console.WriteLine(phrase.Substring(6,3));


            //-----NUMBERS
            //Console.WriteLine(Math.Abs(-100));
            //Console.WriteLine(Math.Sqrt(81));
            //Console.WriteLine(Math.Round(3.901));


            //CALCULATOR
            //Console.WriteLine("Enter a number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(number1 + number2);


            //MAD LIB
            //string color, pluralNoun, celebrity;
            //Console.WriteLine("Enter a color: ");
            //color = Console.ReadLine();

            //Console.WriteLine("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.WriteLine("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love " + celebrity);


            //-----ARRAYS
            //int[] luckyNumbers = {1,2,3,4 };
            //string[] friends = new string [2];
            //friends[0] = "Rachael";
            //friends[1] = "Monica";
            //Console.WriteLine(friends);

            //-----METHODS
            //hello()

            //-----RETURN METHODS
            //Console.WriteLine(cube(5));


            //-----IF STATEMENTS
            //bool is_male = true;
            //bool is_tall = true;

            //if (is_male && is_tall) { Console.WriteLine("you cannot bear children "); }
            //else if (is_male && !is_tall) { Console.WriteLine("you are a short male "); }
            //else if (!is_male && is_tall) { Console.WriteLine("you are not male but you are tall "); }
            //else { Console.WriteLine("You are not male or tall"); }


            //-----IF STATEMENTS COMPARISONS
            //Console.WriteLine(getMax(2, 5, 8));


            //-----SWITCH STATEMENTS
            //Console.WriteLine(GetDay(10));


            //-----FOR LOOP
            //int[] luckyNumbers = {1,2,7,77,666,909 };
            //for (int i=0;i<luckyNumbers.Length;i++) {
            //    Console.WriteLine(luckyNumbers[i]);
            //}


            //-----get exponent method
            //Console.WriteLine(GetPow(3, 2));

            //-----2D ARRAYS
            //int[,] grid = new int [2,5] {
            //    {1,2,3,4,5},
            //    {6,7,8,9,10 }
            //};

            //foreach (int row in grid)
            //{
            //    Console.WriteLine(row);
            //}

            Book book1 = new Book("Harry Potter - Philosopher Stone", "JK Rowling",350);
            //book1.title = "Harry Potter - Philosopher Stone";
            //book1.author = "JK Rowling";
            //book1.pages = 350;

            

            Book book2 = new Book("Harry Potter - Chamber of Secrets", "JK Rowling",200);
            //book2.title = "Harry Potter - Chamber of Secrets";
            //book2.author = "JK Rowling";
            //book2.pages = 200;

            book2.print_info();


        }

        //static int GetPow(int baseNum, int powNum) {
        //    int result = 1;
        //    for (int i=0;i<powNum;i++) {
        //        result = result * baseNum;
        //    }
        //    return result;
        //}

        //static string GetDay(int day) {
        //    string dayName = "";

        //    switch (day)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid Day Number";
        //            break;
        //    }

        //    return dayName;
        //}

        //static int getMax(int num1, int num2, int num3) {

        //    if (num1 >= num2 && num1 >= num3){ return num1; }
        //    else if (num2 >= num1 && num2 >= num3){ return num2; }
        //    else { return num3; }

        //    //return Math.Max(num1, num2);
        //}

        //static double cube(int num) {
        //    double tmp = Math.Pow(Convert.ToDouble(num), Convert.ToDouble(3));
        //    return tmp;
        //}

        //static void hello()
        //{
        //    string me = "Bob";
        //    int age = 25;
        //    SayHi(me, age);
        //    SayHi(me, age);
        //}
        //static void SayHi(string name, int age) {
        //    Console.WriteLine("Hello " + name + " you are " + age);
        //}
    }
}
