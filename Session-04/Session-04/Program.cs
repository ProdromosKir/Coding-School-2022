// See https://aka.ms/new-console-template for more information
using Session_04;


//Exercise 1

var c1 = new Class1();

string result = c1.ReverseString("Prodromos");
Console.WriteLine("Exercise 1. ");
Console.Write(result);
//Console.ReadLine(); 

Console.WriteLine();
Console.WriteLine("---------------------");


//Exercise 2

var c2 = new Class2();
Console.WriteLine("Exercise 2.");
int number = c2.SelectNumber();
bool select =  c2.SumOrProduct();

if (select == false)
{
    c2.CalculateSum(number);
}
else
{
    c2.CalculateProduct(number);
}

Console.WriteLine("---------------------");



//Exercise 3

var c3 = new Class3();
Console.WriteLine("Exercise 3.");
int numberForPrimes = c3.SelectNumber();
c3.FindingPrimes(numberForPrimes);






//Exercise 4

Console.WriteLine("Exercise 4.");

var c4 = new Class4();
int[] Array1 = { 2, 4, 9, 12 };
int[] Array2 = { 1, 3, 7, 10 };
c4.Multiply2Arrays(Array1,Array2);

Console.WriteLine("---------------------");


//Exercise 5

Console.WriteLine("Exercise 5.");

 int[] Array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
 int arrayLength = Array.Length;
 
var c5 = new Class5();
int[] sortedArray = c5.BubbleSorting(Array);
c5.PrintSortedArray(sortedArray);


Console.ReadLine();