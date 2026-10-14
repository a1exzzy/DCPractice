using System;
using csharp_basics.Enums;

namespace csharp_basics.Models;

public class PaintProduct
{
    //属性要大写！！！
    //name, price, type
    public string Name;
    public decimal Price{get;private set;}
    public PaintType PaintType; //这里为什么不是 enum painttype?
    //enum 只在定义枚举时使用 不能写成 enum painttype，因为那会被理解成你正在重新定义一个枚举
    //57:42
    //类是用来规范 但是使用的时候得使用 他的实体
    //比如 System.Console.WriteLine(PaintProduct.Name);就是错的
    //咋使用？new一个对象
  




    //方法
    public void PrintPaintInfo ()
    {
        string descriptionOfPaint = $"Name: {Name}, Price: {Price}, Type: {PaintType}";
        
        System.Console.WriteLine(descriptionOfPaint);
    }
}
