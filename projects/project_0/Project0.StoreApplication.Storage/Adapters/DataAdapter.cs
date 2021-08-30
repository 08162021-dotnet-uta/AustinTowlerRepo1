// using System;
// using System.Collections.Generic;
// using Project0.StoreApplication.Domain.Models;
// using Microsoft.EntityFrameworkCore.Design;

// namespace Project0.StoreApplication.Storage.Adapters
// {
//     public class DataAdapter : DbContext
//     {

//         public DbSet<Customer> Customers {get; set;}
//         public DbSet<Order> Orders {get; set;}
//         public DbSet<Product> Products {get; set;}
//         public DbSet<Store> Store {get; set;}

//         protected override void OnConfiguring(DbContextOptionBuilder builder)
//         {
//             builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StoreApplicationDB;Trusted_Connection=True");
//         }

//         public List<Customer> ReadCustomers()
//         {
//             return null;
//         }

//     }
// }