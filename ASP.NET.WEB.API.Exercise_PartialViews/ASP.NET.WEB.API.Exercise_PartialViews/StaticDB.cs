using ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain;
using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace ASP.NET.WEB.API.Exercise_PartialViews
{
    public static class StaticDB
    {
        public static List<Vehicles> vehicles;
        public static List<User> users;
        public static List<Orders> orders;

        static StaticDB()
        {
            vehicles = new List<Vehicles>()
            {
                new Vehicles()
                {
                    Id = 1,
                    Color = "Metallic - Grey",
                    VehicleKind = Kind.Car,
                    Type = "Mercedes-Benz",
                    Mark = "A-Class",
                    Price = 56.95,
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/1/15/Mercedes-Benz_A_180_BlueEFFICIENCY_Urban_%28W_176%29_%E2%80%93_Frontansicht%2C_3._M%C3%A4rz_2013%2C_D%C3%BCsseldorf.jpg"

                },
                new Vehicles()
                {
                    Id = 2,
                    Color = "Blue-Light",
                    VehicleKind = Kind.Car,
                    Type = "Seat",
                    Mark = "Toledo",
                    Price = 49.35,
                    ImgUrl = "https://en.wikipedia.org/wiki/SEAT_Toledo#/media/File:2014_SEAT_Toledo_SE_TSi_1.2_Front.jpg"

                },
                 new Vehicles()
                {
                    Id = 3,
                    Color = "White",
                    VehicleKind = Kind.Car,
                    Type = "Kia",
                    Mark = "Cadenza",
                    Price = 52.69,
                    ImgUrl = "https://en.wikipedia.org/wiki/Kia_Cadenza#/media/File:Kia_Cadenza_V6_EX_2010_(14429289169).jpg"

                },
                 new Vehicles()
                {
                    Id = 4,
                    Color = "White",
                    VehicleKind = Kind.Jeep,
                    Type = "Jeep Cherokee",
                    Mark = "KL",
                    Price = 74.15,
                    ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTVuB7AHykwQWxttSeZYsm0CMvZER5PjmwbVQ&usqp=CAU"

                },
                 new Vehicles()
                {
                    Id = 5,
                    Color = "Red",
                    VehicleKind = Kind.Jeep,
                    Type = "Lada",
                    Mark = "Niva",
                    Price = 48.95,
                    ImgUrl = "https://en.wikipedia.org/wiki/Lada_Niva#/media/File:Budapest,_Hungexpo,_AMTS_2017,_51.jpg"

                },
                  new Vehicles()
                {
                    Id = 6,
                    Color = "Metallic-Black-Green",
                    VehicleKind = Kind.Motorbike,
                    Type = "Kavasaki Ninja",
                    Mark = "H2R",
                    Price = 38.35,
                    ImgUrl = "https://en.wikipedia.org/wiki/Kawasaki_Ninja_H2#/media/File:Kawasaki_Ninja_H2R_Seattle_motorcycle_show.jpg"

                },
                  new Vehicles()
                {
                    Id = 7,
                    Color = "Metallic-Black-Green",
                    VehicleKind = Kind.Scooter,
                    Type = "Vespa",
                    Mark = "LX-150",
                    Price = 31.05,
                    ImgUrl = "https://cdn.imotorbike.my/images/vespa-lx-150-2015-vespa-lx-150-yellow-91731f5d-d60e-4484-864a-493c8e3a9450.webp"

                },
                  new Vehicles()
                {
                    Id = 8,
                    Color = "Dark-Blue",
                    VehicleKind = Kind.Scooter,
                    Type = "Jupiter",
                    Mark = "TVS",
                    Price = 27.00,
                    ImgUrl = "https://en.wikipedia.org/wiki/TVS_Jupiter#/media/File:TVS_Jupiter.jpg"

                },
                  new Vehicles()
                {
                    Id = 9,
                    Color = "Black",
                    VehicleKind = Kind.Scooter,
                    Type = "Dualtron",
                    Mark = "Storm",
                    Price = 21.30,
                    ImgUrl = "https://www.dualtron.es/wp-content/uploads/2020/03/dualtron-spider-300x300.jpg"

                },
                  new Vehicles()
                {
                    Id = 10,
                    Color = "White-Black",
                    VehicleKind = Kind.Bicycle,
                    Type = "Pinterest Anthem",
                    Mark = "X1 W",
                    Price = 17.30,
                    ImgUrl = "https://i.pinimg.com/originals/ba/6a/df/ba6adf9d18e55399b8993061103f7440.jpg"

                },
                  new Vehicles()
                {
                    Id = 11,
                    Color = "Black-Green-Yellow",
                    VehicleKind = Kind.Bicycle,
                    Type = "BMX",
                    Mark = " - ",
                    Price = 14.99,
                    ImgUrl = "https://www.activethrills.com/wp-content/uploads/2020/04/tony-hawk-dynacraft-bmx-bike.jpg"

                },
                  new Vehicles()
                {
                    Id = 11,
                    Color = "Dark-Green",
                    VehicleKind = Kind.Boat,
                    Type = "Fishing Boat",
                    Mark = "M-Boat 270 S ",
                    Price = 19.94,
                    ImgUrl = "https://www.mivardi.com/runtime/cache/images/1400x1052/m-mb235s-m-mb275s_clun.jpg.jpg"

                },
                  new Vehicles()
                {
                    Id = 12,
                    Color = "Dark-Green",
                    VehicleKind = Kind.SpeedBoat,
                    Type = "jeanneau",
                    Mark = "NC 37",
                    Price = 31.55,
                    ImgUrl = "https://app.jeanneau.com/static/media/image/exterior/sd/dc687fbff10eeb9dced7afc96330e09c.jpg"

                },
            };
            users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Viktor",
                    LastName = "Zafirovski",
                    BirthDay = new DateTime(1982/05/26),
                    
                    Entitie = Entitie.Admin,
                    Gender = Gender.Male,
                    Adress = "Ohridska 10",
                    Phone = 077617871,
                    IDCardNumber = 025552038

                },
                 new User()
                {
                    Id = 2,
                    FirstName = "Tomi",
                    LastName = "Djeery",
                    BirthDay = new DateTime(1996/09/08),
                    
                    Gender = Gender.Male,
                    Adress = "bul.ASNOM 23/4",
                    Phone = 072937805,
                    IDCardNumber = 05454667

                },
                 new User()
                {
                    Id = 3,
                    FirstName = "Stefanija",
                    LastName = "Jakimovska",
                    BirthDay = new DateTime(1976/11/14),
                    Gender = Gender.Female,
                    Adress = "Makedonija 123a",
                    Phone = 071222337,
                    IDCardNumber = 09821056

                },
            };
            orders = new List<Orders>()
            {
                new Orders()
                {
                    Id = 1,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[0],
                },
                new Orders()
                {
                    Id = 2,
                    isRented = true,
                    RentDate = new DateTime(2020/06/23),
                    Days = 160,
                    vehicles = vehicles[1],
                    user = users[0]
                },
                new Orders()
                {
                    Id = 3,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[2],

                },
                new Orders()
                {
                    Id = 4,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[3],

                },
                new Orders()
                {
                    Id = 5,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[4],

                },
                new Orders()
                {
                    Id = 6,
                    isRented = true,
                    RentDate = new DateTime(2020/08/19),
                    Days = 60,
                    vehicles = vehicles[5],
                    user = users[1]
                },
                new Orders()
                {
                    Id = 7,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[6],

                },
                new Orders()
                {
                    Id = 8,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[7],

                },
                new Orders()
                {
                    Id = 9,
                    isRented = true,
                    RentDate = new DateTime(2020/07/04),
                    Days = 135,
                    vehicles = vehicles[8],
                    user = users[2]
                },
                 new Orders()
                {
                    Id = 10,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[9],

                },
                  new Orders()
                {
                    Id = 11,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[10],

                },
                   new Orders()
                {
                    Id = 12,
                    isRented = false,
                    RentDate = DateTime.Now,
                    Days = 1,
                    vehicles = vehicles[11],

                }
            };
            
        }
    }
}
