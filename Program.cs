using System;
namespace UserNamespace
{
    public class User
    {
        public string user_id = "ADMIN ";
        protected string user_password = "ADMIN1823";
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("JEROME ", " 18 ", " 111800 ");
           

            Console.WriteLine(admin.toString());
        }
        public static bool verifyLogin(string id, string pass)
        {
            return verifyLogin(id, pass);
        }
        public void updatePassword(string newPassword)
        {
        }
    }

}
public class Administrator
{
    string id;
    string pass;
    string name;
    public Administrator(string name, string id, string pass)
    {
        this.id = id;
        this.pass = pass;
        this.name = name;
    }
    public void updatePassword(string newPassword)
    {
    }
    public void updateAdminName(string name)
    {
    }

 public string toString()
    {
        return id + name + pass;
    }
}
