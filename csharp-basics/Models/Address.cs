using System;

namespace csharp_basics.Models;

public class Address
{
    public Address()
    {
        createDate = DateTime.Now;
    }
    public readonly DateTime createDate;
    public string Street { get; private set; }

    public const string Country = "Australia";

    public string City { get; set; }

    public void ChangeAddress(string street, string city)
    {
        //If street is null or empty throw error
        //if(street == null || street == "")
        //can also be write as:
        if(string.IsNullOrEmpty(street))
        {
            throw new Exception( "Address can not be null");
    
        }
        if (string.IsNullOrEmpty(city))
        {
            throw new Exception( "Address can not be null");
        }
        City = city;

        Street = street;
    }
}
