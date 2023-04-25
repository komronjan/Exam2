System.Console.Write("From = ");
var y=Convert.ToInt32(Console.ReadLine());
System.Console.Write("To = ");
var x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
while(y<=x)
{
    for (int j=1;j<=10;j++){
        System.Console.WriteLine(y+"x"+j+"="+y*j);
    }
    System.Console.WriteLine();
    y++;
}