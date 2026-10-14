using System;

namespace csharp_basics.Models;

public abstract class User
{
    //constructor 构造函数 是类的成员
    //没有返回值的函数连void都没有
    //构造函数的名字必须是类的名字

    //唯一的目的就是定义对象在创建时的初始化
    public User(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set;}
    public int Age { get; set;}
    public Address Address { get; set;}

    public int GetId()
    {
        return Id;
    }
    public virtual void DisplayUserInfo(){
        string userInfo = $"For this user, Name: {Name}, Age: {Age}";
        System.Console.WriteLine(userInfo);
    }

    public void UpdateUserInfo(string name, int age){
        Name = name;
        Age = age;       
    }
    //如果我们想要添加参数
    public void UpdateUserInfoProMax (string name, int age , Address address){
        Name = name;
        Age = age;       
        Address = address;
    }

    //继续添加呢？？？难道再写一个吗？？
    //方法的重载
    //overloading
    //签名
    // 这就可以了 
    public void UpdateUserInfo(string name, int age , Address address){
        Name = name;
        Age = age;       
        Address = address;
    }

    //abstract  method
    public abstract void UpdateUserInfo2();

}