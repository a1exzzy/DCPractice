using System;

namespace csharp_basics.Models;

public class GuestUser : User
{
    public GuestUser(int id) : base(id)
    {
        
    }
    void Register()
    {
        
    }

    public override void DisplayUserInfo()
    {
        string userInfo = $"For this guestuser, Name: {Name}, Age: {Age}";
        System.Console.WriteLine(userInfo);
    }
    public override void UpdateUserInfo2()
    {
        throw new NotImplementedException();
    }
}
