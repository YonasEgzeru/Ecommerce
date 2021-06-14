using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Ecommerce.Entity
{
    public class DataIntializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var cats = new List<Category>()
            {
                new Category(){ Name = "Computer", Description = "Personal Computer"},
                new Category(){ Name = "Camera", Description = "Professional Camera"},
                new Category(){ Name = "Phone", Description = "Smart Phones"},
                new Category(){ Name = "TV", Description = "Smart TV"},
            };

            foreach (var cat in cats)
            {
                context.Categories.Add(cat);
            }
            context.SaveChanges();

            var prods = new List<Product>()
            {
                new Product(){ Name = "Macbook Air MQD32TU/A",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =1200 , Stock =15 , IsApproved =false , CategoryId = 1,IsHome = false,Image = "apple-mqd32tu-a.jpg"},

                new Product(){ Name = "Canon EOS 2000D",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =4100 , Stock =12 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "canon-eos-2000d.jpg"},

                new Product(){ Name = "Huawei P30 Pro",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =900 , Stock =10 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "huawei-p30-pro.jpg"},

                new Product(){ Name = "Samsung UE-55NU8000",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =1000 , Stock =19 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "samsung-55nu8000.jpg"},

                new Product(){ Name = "Samsung Galaxy S10 Plus",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =1300 , Stock =21 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "samsung-galaxy-s10-plus.jpg"},

                new Product(){ Name = "Macbook Pro MPXR2TU/A",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =2000 , Stock =18 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "macbook-pro-mpxr2tu-a.png"},

                new Product(){ Name = "Lenovo Yoga 530 81EK00DUTX",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =1100 , Stock =14 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "lenovo-yoga-530-81ek00dutx.jpg"},

                new Product(){ Name = "Nikon D3500",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =5300 , Stock =13 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "nikon-d3500.jpg"},

                new Product(){ Name = "iPhone X",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =900 , Stock =111 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "iphone-x.jpg"},

                new Product(){ Name = "LG 55UK6470PLC",Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price =800 , Stock =10 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "lg-55uk6470plc.jpg"},

            };

            foreach (var prod in prods)
            {
                context.Products.Add(prod);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}