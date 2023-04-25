using Task4;

var u1= new User(){
FirstName=Console.ReadLine(),
LastName=Console.ReadLine(),
Password=Console.ReadLine(),
UserName=Console.ReadLine(),
};
var service=new Users();
service.Login(u1);
