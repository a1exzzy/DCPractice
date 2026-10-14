using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace csharp_basics.Models;

public class Order
{
    //public PaintProduct PaintProduct { get; set; }

    //change this to list<T>
    public List<PaintProduct> PaintProducts { get; set; }

    //变成了多个PaintProduct元素的集合

    //constructor
    //关于默认值：
    //reference type: default value is null
    //bool: false
    //int: 0

    //PaintProduct也是引用类型 所以他也是null

    public Order()
    {  

        //录屏第十期44：00
        //如果我们试图直接添加元素会报错
        //所以先initialize
        PaintProducts = new List<PaintProduct>();

        //NullReference Exception
        //PaintProducts.Add();

        //PaintProducts.Add(new PaintProduct());

        
    }

    //3个方法
    //Add a new product
    public void AddProduct(PaintProduct item){
        PaintProducts.Add(item);
    }

        //Remove an existing product
    public void RemoveProduct(PaintProduct item){
        PaintProducts.Remove(item);
    }

    //Chech if a product exist
    public bool CheckProduct(PaintProduct item){
        //PaintProducts.Count();
        return PaintProducts.Contains(item);
    }

    //check if any product in the list has name of null
    public bool CheckAnyNameNull(){
        //iterate all elements in list
        return PaintProducts.Any(item => string.IsNullOrEmpty(item.Name));

                //return PaintProducts.Any(item => item.Name== "null");
        //return PaintProducts.Any(item => string.IsNullOrEmpty(item.Name));


    }

    //【作业】
    //find the most expensive paint
    public void GetMostExpensivePaintProduct()
    {
        
    }

    //Fully remove certain paint



    //find every paint which has price > X and < Y



    //sum the prices of all paint


    //LINQ练习
    //fetch products which has price higher than 10
    public List<PaintProduct> FetchExpensiveProducts(){
        return PaintProducts.Where(item => item.Price > 10).ToList();
    }


    //find one product which have price of 9.9
    public PaintProduct FetchProductWithCertainPrice(){
        //return PaintProducts.Where(item => item.Price == 9.9m).Single();
        //return PaintProducts.Where(item => item.Price == 9.9m).First();//那么没找到也会报错
        //return PaintProducts.Where(item => item.Price == 9.9m).FirstOrDefault();//找到就第一个 没找到就给默认的null
        return PaintProducts.FirstOrDefault(item => item.Price == 9.9m);
    }
}
