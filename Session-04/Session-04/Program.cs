// See https://aka.ms/new-console-template for more information
using Session_04;

Console.WriteLine("Hello, World!");

var c1 = new Class1();

string result = c1.ReverseString("Prodromos");
Console.WriteLine(result);  
//Console.ReadLine(); 



var c2 = new Class2();
Console.WriteLine("Give an integer: ");
String stringNumber = Console.ReadLine();
int number = Convert.ToInt32(stringNumber);
bool select =  c2.SumOrProduct();

if (select == false)
{
    c2.CalculateSum(number);
}
else
{
    c2.CalculateProduct(number);
}

Console.ReadLine();