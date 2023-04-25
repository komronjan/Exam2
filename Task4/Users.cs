namespace Task4;

public class Users 
{
   List<User> _user;
   public Users()
   {
    _user=new List <User>();
   }
   public List<User> GetInfo(){

      return _user;
   }
   public void Login(User _user){
      
      if (_user.FirstName=="Komronjon" && _user.LastName=="Akramov" && _user.Password=="koma"&&_user.UserName=="akramov.8_"){
         System.Console.WriteLine("Login successful! Welcome mr " + _user.FirstName+" "+ _user.LastName+" ");
      }
      else{
         System.Console.WriteLine("Login failed!)");
      }
   }
}
