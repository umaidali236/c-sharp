
// Assignment-2 #Program to swap two numbers

Console.WriteLine("Enter the value of a  : ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter the value of b  : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Before swapping : \n a = {a} \n b = {b}" );
int temp = a;
a = b;
b= temp;
Console.WriteLine($"After swapping : \n a = {a} \n b = {b}");
