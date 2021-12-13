using System;
using RealizedSaleDevices.Models;
using System.Collections.Generic;
using System.Linq;
using RealizedSaleDevices.Repository;

namespace RealizedSaleDevices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dbContext = new StoreContext();
            var colorRepository = new ColorRepository(dbContext);
            var memorySizeRepository = new MemorySizeRepository(dbContext);
            var deviceTypeRepository = new DeviceTypeRepository(dbContext);
            {
                // Type devices
                var deviceTypePhone = new DeviceType 
                {
                    Type = "Phone"
                };
                var deviceTypeTablet = new DeviceType
                {
                    Type = "Tablet"
                };
                var deviceTypeNotebook = new DeviceType
                {
                    Type = "Notebook"
                };

                // Colors
                var colorBlack = new Color
                {
                    ColorDevice = "Black"
                };
                var colorWhite = new Color
                {
                    ColorDevice = "White"
                };
                var colorSilver = new Color
                {
                    ColorDevice = "Silver"
                };
                var colorSpaceGray = new Color
                {
                    ColorDevice = "SpaceGray"
                };
                var colorGold = new Color
                {
                    ColorDevice = "Gold"
                };
                var colorPinckGold = new Color
                {
                    ColorDevice = "PinckGold"
                };
                var colorGreen = new Color
                {
                    ColorDevice = "Green"
                };
                var colorYellow = new Color
                {
                    ColorDevice = "Yellow"
                };
                var colorBlue = new Color
                {
                    ColorDevice = "Blue"
                };
                var colorRed = new Color
                {
                    ColorDevice = " Red"
                };
                var colorPurple = new Color
                {
                    ColorDevice = " Purple"
                };
                var colorOrange = new Color
                {
                    ColorDevice = "Orange"
                };

                // Memory sizes
                var memorySize32 = new MemorySize
                {
                    MemorySizeDevice = 32
                };
                var memorySize64 = new MemorySize
                {
                    MemorySizeDevice = 64
                };
                var memorySize128 = new MemorySize
                {
                    MemorySizeDevice = 128
                };
                var memorySize256 = new MemorySize
                {
                    MemorySizeDevice = 256
                };
                var memorySize512 = new MemorySize
                {
                    MemorySizeDevice = 512
                };
                var memorySize1024 = new MemorySize
                {
                    MemorySizeDevice = 1024
                };

                // Phones
                var black = colorRepository.Get(97);
                var white = colorRepository.Get(98);
                var silver = colorRepository.Get(99);
                var spaceGray = colorRepository.Get(100);
                var gold = colorRepository.Get(101);
                var green = colorRepository.Get(103);

                var size64 = memorySizeRepository.Get(69);
                var size128 = memorySizeRepository.Get(68);
                var size256 = memorySizeRepository.Get(67);

                var phone = deviceTypeRepository.Get(86);

                var pSe64 = new Device
                {
                    Model = "iPhone SE",
                    Price = 1299.0,
                    Color = black,
                    MemorySize = size64,
                    DeviceTypes = phone
                };
                var pSe128 = new Device
                {
                    Model = "iPhone SE",
                    Price = 1499.0,
                    Color = white,
                    MemorySize = size128,
                    DeviceTypes = phone
                };
                var pSe256 = new Device
                {
                    Model = "iPhone SE",
                    Price = 2099.0,
                    Color = spaceGray,
                    MemorySize = size256,
                    DeviceTypes = phone
                };
                var p11_64 = new Device
                {
                    Model = "iPhone 11",
                    Price = 1999.0,
                    Color = green,
                    MemorySize = size64,
                    DeviceTypes = phone
                };
                var p11_128 = new Device
                {
                    Model = "iPhone 11",
                    Price = 2199.0,
                    Color = white,
                    MemorySize = size128,
                    DeviceTypes = phone
                };
                var pXr64 = new Device
                {
                    Model = "iPhone XR",
                    Price = 1899.0,
                    Color = white,
                    MemorySize = size64,
                    DeviceTypes = phone
                };
                var pXr128 = new Device
                {
                    Model = "iPhone XR",
                    Price = 2099.0,
                    Color = gold,
                    MemorySize = size128,
                    DeviceTypes = phone
                };
                var p12mini128 = new Device
                {
                    Model = "iPhone 12 mini",
                    Price = 2499.0,
                    Color = white,
                    MemorySize = size128,
                    DeviceTypes = phone
                };
                var p12mini256 = new Device
                {
                    Model = "iPhone 12 mini",
                    Price = 3199.0,
                    Color = gold,
                    MemorySize = size256,
                    DeviceTypes = phone
                };

                // Customers
                var customer1 = new Customer
                {
                    Name = "Ruslan",
                    PhoneNumber = "+375 33 300 00 00"
                };
                var customer2 = new Customer
                {
                    Name = "Stas",
                    PhoneNumber = "+375 29 200 00 00"
                };
                var customer3 = new Customer
                {
                    Name = "Anna",
                    PhoneNumber = "+375 25 900 00 00"
                };

                // Realized sales
                var realizeSale1 = new RealizedSale
                {
                    Amount = 1,
                    TotalSum = 3199.0,
                    Date = "09.12.2021",
                    Customer = customer1,
                    Device = p12mini256
                };
                var realizeSale2 = new RealizedSale
                {
                    Amount = 1,
                    TotalSum = 2199.0,
                    Date = "30.10.2021",
                    Customer = customer2,
                    Device = p11_128
                };
                var realizeSale3 = new RealizedSale
                {
                    Amount = 1,
                    TotalSum = 2499.0,
                    Date = "09.09.2021",
                    Customer = customer3,
                    Device = pXr128
                };
                var realizeSale4 = new RealizedSale
                {
                    Amount = 1,
                    TotalSum = 2099.0,
                    Date = "09.09.2021",
                    Customer = customer3,
                    Device = p12mini128
                };

                var colors = new List<Color>
                {
                    colorBlack, colorWhite, colorSilver, colorSpaceGray, colorGold, colorPinckGold, colorGreen,
                    colorYellow, colorBlue, colorRed, colorPurple, colorOrange
                };

                var memorySize = new List<MemorySize>
                {
                    memorySize32, memorySize64, memorySize128, memorySize256, memorySize512, memorySize1024
                };

                var deviceType = new List<DeviceType>
                {
                    deviceTypePhone, deviceTypeTablet, deviceTypeNotebook
                };

                var device = new List<Device>
                {
                    pSe64, pSe128, pSe256, p11_64, p11_128, pXr64, pXr128, p12mini128, p12mini256
                };

                var customer = new List<Customer>
                {
                    customer1, customer2, customer3
                };

                //var realizeSale = new List<RealizedSale>
                //{
                //    realizeSale1, realizeSale2, realizeSale3, realizeSale4
                //};

                // Device type
                //dbContext.DeviceTypes.AddRange(deviceType);

                //dbContext.SaveChanges();

                // Color
                //dbContext.Colors.AddRange(colors);

                //dbContext.SaveChanges();

                // Memory size
                //dbContext.Memory.AddRange(memorySize);

                //dbContext.SaveChanges();

                // Phone
                //dbContext.Devices.AddRange(device);

                //dbContext.SaveChanges();

                // Customer
                //dbContext.Customers.AddRange(customer);
                
                //  Realize sale
                //dbContext.RealizedSales.AddRange(realizeSale);

                //dbContext.SaveChanges();
            }

            var printConsoleContext = new StoreContext();
            {
                // Получаем объекты из бд и выводим на консоль;
                var colors = printConsoleContext.Colors.ToList();
                Console.WriteLine("Данные таблицы Colors:");
                foreach (Color c in colors)
                {
                    Console.WriteLine($"{c.Id}--{c.ColorDevice}");
                }

                var memorySizes = printConsoleContext.Memory.ToList();
                Console.WriteLine("\nДанные таблицы MemorySizes:");
                foreach (MemorySize m in memorySizes)
                {
                    Console.WriteLine($"{m.Id}--{m.MemorySizeDevice}");
                }

                var deviceTypePhone = printConsoleContext.DeviceTypes.ToList();
                Console.WriteLine("\nДанные таблицы DeviceType:");
                foreach (DeviceType d in deviceTypePhone)
                {
                    Console.WriteLine($"{d.Id}--{d.Type}");
                }

                var devicePhone = printConsoleContext.Devices.ToList();
                Console.WriteLine("\nДанные таблицы Device:");
                Console.WriteLine($"\nID--DeviceType--Model--ColorId--MemorySizeId--Price");
                foreach (Device d in devicePhone)
                {
                    Console.WriteLine($"{d.Id}--{d.DeviceTypeId}--{d.Model}--{d.ColorId}--{d.MemorySizeId}--{d.Price}");
                }
            }
        }
    }
}
