﻿using _04_OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product { Id=2, CategoryId=5,UnitsInStock=5,
    ProductName="Kalem",UnitPrice=35 };

//PascalCase   //camelCase
//case sensitive
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);



//productManager.Topla2(3, 6);

//int toplamaSonucu = productManager.Topla(3, 6);

//Console.WriteLine(toplamaSonucu*2);

//int sayi = 100;
//productManager.Update(sayi);
//Console.WriteLine(sayi);

//int,double,bool... değer tip(value)
//diziler,class,abstract class, interface ... referans tip(reference)
//ref out
