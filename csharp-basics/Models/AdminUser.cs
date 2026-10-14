using System;

namespace csharp_basics.Models;

public class AdminUser : User
{
    public AdminUser(int id):base (id)
    {
        //之前user的构造器已经写过 id了
        //所以这里也不需要
        //id = Id;
    }
    public void DeleteAddress()
    {
        Address = null; 
    }

    //改写父类的方法
    public override void DisplayUserInfo(){
        string userInfo = $"For this adminuser, Name: {Name}, Age: {Age}";
        System.Console.WriteLine(userInfo);
    }

    //抽象方法重写
    public override void UpdateUserInfo2()
    {
        throw new NotImplementedException();
    }
}
