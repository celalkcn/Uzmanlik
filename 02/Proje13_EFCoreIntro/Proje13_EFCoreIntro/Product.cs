using System;

namespace Proje13_EFCoreIntro.Migrations;

public class Product
{
    public  int  Id { get; set; }
    public string Name { get; set; }
    public string Properties { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

}
