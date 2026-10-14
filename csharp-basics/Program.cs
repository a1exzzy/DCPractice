// See https://aka.ms/new-console-template for more information
using csharp_basics.Models;
using csharp_basics.Enums;

Console.WriteLine("Hello, World!");

//Define a string called paint name, and assign value 'Dulux' to it
string paintProduct ="Dulux";
string description = "Dulux is a high sheen level product";

string summary = "Summary: " + paintProduct + " and description is " + description;
//尝试 拼接
string summaryWithInterpolation = $"Summary: {paintProduct} and {description}";

System.Console.WriteLine(summary);
System.Console.WriteLine(summaryWithInterpolation);

//Define an int called num of paints, and assign value 100 to it
int numOfPaints = 100;
//Define a proper data type for the price of paint, and assign value 19.9 to it
decimal priceOfPaint = 19.99m; 

//练习显示转换
double priceOfPaintDouble = (double)priceOfPaint;
System.Console.WriteLine(priceOfPaint);
System.Console.WriteLine(priceOfPaintDouble);

int highSheenLevelPaintType = 1;
int lowSheenLevelPaintType = 2;
int basicSheenLevelPaintType = 3;
 
PaintType duluxPaintType = PaintType.HighSheenLevelPaintType;


System.Console.WriteLine(duluxPaintType);
System.Console.WriteLine((int)duluxPaintType);


switch ((int)duluxPaintType)
{
    case 101:
        description = "High Sheen Level Paint Type";
        break;
    case 102:   
        description = "Low Sheen Level Paint Type";
        break;      
    case 103:
        description = "Basic Sheen Level Paint Type";
        break;  
    default:
    break;
    
    
}
System.Console.WriteLine(description);

switch (duluxPaintType)
{
    case PaintType.HighSheenLevelPaintType:
        description = $"Dulux is {PaintType.HighSheenLevelPaintType}";
        break;
    case PaintType.LowSheenLevelPaintType:
        description = "Enum test tells low Sheen Level Paint Type";
        break;
    case PaintType.BasicSheenLevelPaintType:
        description = "Enum test tells basic Sheen Level Paint Type";
        break;  
    default:
    break;
}
System.Console.WriteLine(description);


//循环语句foreach
//string[]names = {"Larry","Heidi","David"};

//foreach(var name in names)
//{
//    System.Console.WriteLine(name);
//}

string[] productNames = {"Dulux","Nippon", "Rainbow"};

void LoopProductName(string[] productNames, string description)
{
    foreach (var product in productNames){
        System.Console.WriteLine(product);
    }
    System.Console.WriteLine("foreach" + description);
}
//注意！可选参数只能放后面
void LoopProductName2(string[] productNames, string description = "default")
{
    foreach (var product in productNames){
        System.Console.WriteLine(product);
    }
    System.Console.WriteLine("foreach" + description);
}

LoopProductName(productNames, description); 
LoopProductName2(productNames, description); 

PaintProduct paintProduct3 = new PaintProduct();

paintProduct3.Name = paintProduct;

System.Console.WriteLine(paintProduct3.Name); //访问权限不同

//paintProduct3.Price = priceOfPaint;
paintProduct3.PaintType = PaintType.HighSheenLevelPaintType;

//test our print method
paintProduct3.PrintPaintInfo();


AdminUser adminUser = new AdminUser(1);

GuestUser guestUser = new GuestUser(2);

//父类 是user 子类1号 是adminuser 2号是guestuser 他们都是继承但是并不是一样的类
//如何互换？？
User adminUser2 = new AdminUser(3);
//子类可以作为父类的继承者/替代者
//反之则不行 父类不饿能用来替代

//AdminUser adminUser3 = new User(5);
//功能上admin user是强于 user的 


guestUser.UpdateUserInfo("alex",27);



//自己定义一个叫paintType的数据类型 是枚举的数据类型  有限的集合
// //鼠标放上去发现 = 0那就是默认的 but we can also declare the value 
// public enum PaintType
// {
//     HighSheenLevelPaintType = 101,
//     LowSheenLevelPaintType,
//     BasicSheenLevelPaintType
// }




