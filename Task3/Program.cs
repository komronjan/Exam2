using Task3;
while (true)
{
    
    System.Console.Write("      The First number is: ");
    var a= Convert.ToInt32(Console.ReadLine());
    System.Console.Write("      The operation is: ");
    var s=Console.ReadLine();
    System.Console.Write("      The Second number is: ");
    var b=Convert.ToInt32(Console.ReadLine());
    var calculator = new Calculator(a,b);
    if (s=="+")
    System.Console.WriteLine("          "+a+"+"+b+"="+calculator.Sum());
     if (s=="-")
    System.Console.WriteLine("          "+a+"-"+b+"="+calculator.Subtract());
     if (s=="*")
    System.Console.WriteLine("          "+a+"*"+b+"="+calculator.Multiplication());
     if (s=="/")
    System.Console.WriteLine("          "+a+"/"+b+"="+calculator.Division());
}
