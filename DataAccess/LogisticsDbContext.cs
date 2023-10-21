using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccess
{// "Server=.\\SQLEXPRESS;Database=LogisticsDB;Trusted_Connection=True;"
    public class LogisticsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Report> Reports { get; set; }

        public LogisticsDbContext() : base("Server=.\\SQLEXPRESS;Database=LogisticsDB;Trusted_Connection=True;")
        {
            
        }

        public void SeedData()
        {
            List<User> users = new List<User>
            {
                new User
                {
                    Username = "oguzhan3",
                    Email = "oguzhan@example.com",
                    Password = "123456",
                    FirstName = "Oğuzhan",
                    LastName = "Öksel",
                    City = "İstanbul",
                    Address = "Kadıköy Mahallesi, Atatürk Caddesi No: 123",
                    Birthdate = new DateTime(1996, 11, 13),
                    Phone = "0555-123-45-67",
                    Salary = 5000,
                    Status = true,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "manager3",
                    Email = "manager@example.com",
                    Password = "123456",
                    FirstName = "manager",
                    LastName = "manager",
                    City = "Ankara",
                    Address = "Kızılay Mahallesi, Atatürk Bulvarı No: 456",
                    Birthdate = new DateTime(1985, 8, 20),
                    Phone = "0555-987-65-43",
                    Salary = 6000,
                    Status = true,
                    IsManager = true,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "mehmet789",
                    Email = "mehmet@example.com",
                    Password = "sifre789",
                    FirstName = "Mehmet",
                    LastName = "Demir",
                    City = "İzmir",
                    Address = "Konak Mahallesi, Atatürk Caddesi No: 789",
                    Birthdate = new DateTime(1995, 3, 10),
                    Phone = "0555-555-12-34",
                    Salary = 5500,
                    Status = false,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "elif678",
                    Email = "elif@example.com",
                    Password = "sifre678",
                    FirstName = "Elif",
                    LastName = "Koç",
                    City = "Bursa",
                    Address = "Nilüfer Mahallesi, Atatürk Caddesi No: 678",
                    Birthdate = new DateTime(1987, 7, 5),
                    Phone = "0555-777-88-99",
                    Salary = 5200,
                    Status = false,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "ali567",
                    Email = "ali@example.com",
                    Password = "sifre567",
                    FirstName = "Ali",
                    LastName = "Yıldız",
                    City = "Adana",
                    Address = "Seyhan Mahallesi, Atatürk Caddesi No: 567",
                    Birthdate = new DateTime(1980, 12, 15),
                    Phone = "0555-111-22-33",
                    Salary = 6000,
                    Status = false,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "deniz345",
                    Email = "deniz@example.com",
                    Password = "sifre345",
                    FirstName = "Deniz",
                    LastName = "Şahin",
                    City = "Antalya",
                    Address = "Konyaaltı Mahallesi, Atatürk Caddesi No: 345",
                    Birthdate = new DateTime(1983, 4, 25),
                    Phone = "0555-999-88-77",
                    Salary = 5400,
                    Status = true,
                    IsManager = true,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "gizem123",
                    Email = "gizem@example.com",
                    Password = "sifre123",
                    FirstName = "Gizem",
                    LastName = "Aydın",
                    City = "Eskişehir",
                    Address = "Tepebaşı Mahallesi, Atatürk Caddesi No: 123",
                    Birthdate = new DateTime(1992, 8, 3),
                    Phone = "0555-777-55-44",
                    Salary = 5200,
                    Status = true,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "cemal456",
                    Email = "cemal@example.com",
                    Password = "sifre456",
                    FirstName = "Cemal",
                    LastName = "Arslan",
                    City = "Mersin",
                    Address = "Akdeniz Mahallesi, Atatürk Caddesi No: 456",
                    Birthdate = new DateTime(1986, 2, 12),
                    Phone = "0555-888-77-66",
                    Salary = 5300,
                    Status = true,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "elif789",
                    Email = "elif@example.com",
                    Password = "sifre789",
                    FirstName = "Elif",
                    LastName = "Kurt",
                    City = "Konya",
                    Address = "Selçuklu Mahallesi, Atatürk Caddesi No: 789",
                    Birthdate = new DateTime(1998, 11, 30),
                    Phone = "0555-666-99-88",
                    Salary = 5100,
                    Status = true,
                    IsManager = false,
                    IsSuperUser = false
                },
                new User
                {
                    Username = "omer012",
                    Email = "omer@example.com",
                    Password = "sifre012",
                    FirstName = "Ömer",
                    LastName = "Güneş",
                    City = "Gaziantep",
                    Address = "Şahinbey Mahallesi, Atatürk Caddesi No: 012",
                    Birthdate = new DateTime(1993, 6, 8),
                    Phone = "0555-999-66-55",
                    Salary = 5200,
                    Status = true,
                    IsManager = false,
                    IsSuperUser = false
                }
            };

            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "Laptop",
                    Price = 1500.00m,
                    Weight = 2.5m,
                    StockQuantity = 500
                },
                new Product
                {
                    Name = "Smartphone",
                    Price = 800.00m,
                    Weight = 0.3m,
                    StockQuantity = 1000
                },
                new Product
                {
                    Name = "Tablet",
                    Price = 400.00m,
                    Weight = 0.5m,
                    StockQuantity = 750
                },
                new Product
                {
                    Name = "Desktop Computer",
                    Price = 1200.00m,
                    Weight = 10.0m,
                    StockQuantity = 30
                },
                new Product
                {
                    Name = "TV",
                    Price = 800.00m,
                    Weight = 15.0m,
                    StockQuantity = 60
                },
                new Product
                {
                    Name = "Washing Machine",
                    Price = 600.00m,
                    Weight = 40.0m,
                    StockQuantity = 20
                },
                new Product
                {
                    Name = "Refrigerator",
                    Price = 900.00m,
                    Weight = 50.0m,
                    StockQuantity = 25
                },
                new Product
                {
                    Name = "Coffee Maker",
                    Price = 50.00m,
                    Weight = 2.0m,
                    StockQuantity = 70
                },
                new Product
                {
                    Name = "Toaster",
                    Price = 30.00m,
                    Weight = 1.0m,
                    StockQuantity = 90
                },
                new Product
                {
                    Name = "Blender",
                    Price = 40.00m,
                    Weight = 3.0m,
                    StockQuantity = 80
                }
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Plate = "34ABC01",
                    Capacity = 2000.0m,
                    MonthlyExpense = 1000.00m,
                    IsAvailable = true
                },
                new Vehicle
                {
                    Id = 2,
                    Plate = "06XYZ99",
                    Capacity = 1500.0m,
                    MonthlyExpense = 900.00m,
                    IsAvailable = true
                },
                new Vehicle
                {
                    Id = 3,
                    Plate = "35DEF02",
                    Capacity = 2500.0m,
                    MonthlyExpense = 1200.00m,
                    IsAvailable = true
                },
                new Vehicle
                {
                    Id = 4,
                    Plate = "16HIJ73",
                    Capacity = 1800.0m,
                    MonthlyExpense = 950.00m,
                    IsAvailable = true
                },
                new Vehicle
                {
                    Id = 5,
                    Plate = "34LMN04",
                    Capacity = 2200.0m,
                    MonthlyExpense = 1100.00m,
                    IsAvailable = true
                },
                new Vehicle
                {
                    Id = 6,
                    Plate = "07PQR56",
                    Capacity = 1700.0m,
                    MonthlyExpense = 850.00m,
                    IsAvailable = true
                }
            };

            List<Order> orders = new List<Order>
            {
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2021, 5, 10),
                    ShippedDate = new DateTime(2021, 5, 15),
                    DeliveredDate = new DateTime(2021, 5, 20),
                    CanceledDate = null,
                    DestinationAddress = "Istanbul, Kadikoy",
                    TotalWeight = 10.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2021, 6, 5),
                    ShippedDate = new DateTime(2021, 6, 10),
                    DeliveredDate = new DateTime(2021, 6, 15),
                    CanceledDate = null,
                    DestinationAddress = "Ankara, Kizilay",
                    TotalWeight = 15.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2021, 7, 10),
                    ShippedDate = new DateTime(2021, 7, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2021, 7, 20),
                    DestinationAddress = "Izmir, Konak",
                    TotalWeight = 20.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2021, 8, 5),
                    ShippedDate = new DateTime(2021, 8, 10),
                    DeliveredDate = null,
                    CanceledDate = null,
                    DestinationAddress = "Bursa, Nilufer",
                    TotalWeight = 25.0m,
                    OrderStatus = OrderStatus.Pending
                },
                new Order
                {
                    VehicleId = 5,
                    PendingDate = new DateTime(2021, 9, 10),
                    ShippedDate = new DateTime(2021, 9, 15),
                    DeliveredDate = new DateTime(2021, 9, 20),
                    CanceledDate = null,
                    DestinationAddress = "Adana, Seyhan",
                    TotalWeight = 30.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 6,
                    PendingDate = new DateTime(2021, 10, 5),
                    ShippedDate = new DateTime(2021, 10, 10),
                    DeliveredDate = new DateTime(2021, 10, 15),
                    CanceledDate = null,
                    DestinationAddress = "Antalya, Konyaalti",
                    TotalWeight = 35.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2022, 1, 10),
                    ShippedDate = new DateTime(2022, 1, 15),
                    DeliveredDate = new DateTime(2022, 1, 20),
                    CanceledDate = null,
                    DestinationAddress = "Eskisehir, Tepebasi",
                    TotalWeight = 40.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2022, 2, 5),
                    ShippedDate = new DateTime(2022, 2, 10),
                    DeliveredDate = new DateTime(2022, 2, 15),
                    CanceledDate = null,
                    DestinationAddress = "Mersin, Akdeniz",
                    TotalWeight = 45.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2022, 3, 10),
                    ShippedDate = new DateTime(2022, 3, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2022, 3, 20),
                    DestinationAddress = "Konya, Selcuklu",
                    TotalWeight = 50.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2022, 4, 5),
                    ShippedDate = new DateTime(2022, 4, 10),
                    DeliveredDate = new DateTime(2022, 4, 15),
                    CanceledDate = null,
                    DestinationAddress = "Gaziantep, Sahinbey",
                    TotalWeight = 55.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2022, 11, 1),
                    ShippedDate = new DateTime(2022, 11, 5),
                    DeliveredDate = new DateTime(2022, 11, 10),
                    CanceledDate = null,
                    DestinationAddress = "Istanbul, Kadikoy",
                    TotalWeight = 10.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2022, 11, 6),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Ankara, Kizilay",
                    TotalWeight = 15.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2022, 11, 20),
                    DestinationAddress = "Izmir, Konak",
                    TotalWeight = 20.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = null,
                    CanceledDate = null,
                    DestinationAddress = "Bursa, Nilufer",
                    TotalWeight = 25.0m,
                    OrderStatus = OrderStatus.Pending
                },
                new Order
                {
                    VehicleId = 5,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = new DateTime(2022, 11, 20),
                    CanceledDate = null,
                    DestinationAddress = "Adana, Seyhan",
                    TotalWeight = 30.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 6,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Antalya, Konyaalti",
                    TotalWeight = 35.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2022, 11, 1),
                    ShippedDate = new DateTime(2022, 11, 5),
                    DeliveredDate = new DateTime(2022, 11, 10),
                    CanceledDate = null,
                    DestinationAddress = "Eskisehir, Tepebasi",
                    TotalWeight = 40.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2022, 11, 6),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Mersin, Akdeniz",
                    TotalWeight = 45.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2022, 11, 20),
                    DestinationAddress = "Konya, Selcuklu",
                    TotalWeight = 50.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Gaziantep, Sahinbey",
                    TotalWeight = 55.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2022, 11, 1),
                    ShippedDate = new DateTime(2022, 11, 6),
                    DeliveredDate = new DateTime(2022, 11, 11),
                    CanceledDate = null,
                    DestinationAddress = "Istanbul, Kadikoy",
                    TotalWeight = 10.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Ankara, Kizilay",
                    TotalWeight = 15.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2022, 11, 20),
                    DestinationAddress = "Izmir, Konak",
                    TotalWeight = 20.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = null,
                    CanceledDate = null,
                    DestinationAddress = "Bursa, Nilufer",
                    TotalWeight = 25.0m,
                    OrderStatus = OrderStatus.Pending
                },
                new Order
                {
                    VehicleId = 5,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = new DateTime(2022, 11, 20),
                    CanceledDate = null,
                    DestinationAddress = "Adana, Seyhan",
                    TotalWeight = 30.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 6,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Antalya, Konyaalti",
                    TotalWeight = 35.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 1,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = new DateTime(2022, 11, 20),
                    CanceledDate = null,
                    DestinationAddress = "Eskisehir, Tepebasi",
                    TotalWeight = 40.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 2,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Mersin, Akdeniz",
                    TotalWeight = 45.0m,
                    OrderStatus = OrderStatus.Delivered
                },
                new Order
                {
                    VehicleId = 3,
                    PendingDate = new DateTime(2022, 11, 10),
                    ShippedDate = new DateTime(2022, 11, 15),
                    DeliveredDate = null,
                    CanceledDate = new DateTime(2022, 11, 20),
                    DestinationAddress = "Konya, Selcuklu",
                    TotalWeight = 50.0m,
                    OrderStatus = OrderStatus.Canceled
                },
                new Order
                {
                    VehicleId = 4,
                    PendingDate = new DateTime(2022, 11, 5),
                    ShippedDate = new DateTime(2022, 11, 10),
                    DeliveredDate = new DateTime(2022, 11, 15),
                    CanceledDate = null,
                    DestinationAddress = "Gaziantep, Sahinbey",
                    TotalWeight = 55.0m,
                    OrderStatus = OrderStatus.Delivered
                }
            };

            List<OrderItem> orderItems = new List<OrderItem>();
            
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int orderId = random.Next(1, 31);
                int productId = random.Next(1, 11);
                int productQuantity = random.Next(5, 21);

                OrderItem orderItem = new OrderItem
                {
                    OrderId = orderId,
                    ProductId = productId,
                    ProductQuantity = productQuantity
                };

                orderItems.Add(orderItem);
            }

            Users.AddRange(users);
            Products.AddRange(products);
            Vehicles.AddRange(vehicles);
            Orders.AddRange(orders);
            OrderItems.AddRange(orderItems);

            SaveChanges();
        }
    }
}
