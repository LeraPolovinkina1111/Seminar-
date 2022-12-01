

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
while  (a>999)  a=a/10;
{
    if (a<100)
    {
        Console.WriteLine("число не трехзначное");
    }
    else ;
    
}
System.Console.WriteLine(a%10);

