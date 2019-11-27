#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentialJS2MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<OrderDetail> Order = new List<OrderDetail>
    {
        new OrderDetail { OrderID = 1001, EmployeeID = 1, Freight = 2.3, ShipCity = "Seattle", ShipName = "White Clover Markets" },
        new OrderDetail { OrderID = 1002, EmployeeID = 2, Freight = 3.3, ShipCity = "Reims", ShipName = "Vins et alcools Chevalier" },
        new OrderDetail { OrderID = 1003, EmployeeID = 3, Freight = 5.3, ShipCity = "Boise", ShipName = "Save-a-lot Markets" },
        new OrderDetail { OrderID = 1004, EmployeeID = 4, Freight = 2.3, ShipCity = "Reims", ShipName = "Vins et alcools Chevalier" },
        new OrderDetail { OrderID = 1005, EmployeeID = 5, Freight = 5.3, ShipCity = "Boise", ShipName = "Save-a-lot Markets" },
        new OrderDetail { OrderID = 1006, EmployeeID = 6, Freight = 9.3, ShipCity = "Lyon", ShipName = "Victuailles en stock" },
        new OrderDetail { OrderID = 1007, EmployeeID = 7, Freight = 6.3, ShipCity = "Albuquerque", ShipName = "Rattlesnake Canyon Grocery" },
        new OrderDetail { OrderID = 1008, EmployeeID = 8, Freight = 4.3, ShipCity = "Lyon", ShipName = "Victuailles en stock" },
        new OrderDetail { OrderID = 1009, EmployeeID = 9, Freight = 6.3, ShipCity = "Albuquerque", ShipName = "Rattlesnake Canyon Grocery" },
        new OrderDetail { OrderID = 1010, EmployeeID = 10, Freight = 4.3, ShipCity = "Strasbourg", ShipName = "Blondel et fils" }
    };
        List<Employee> EmployeesData = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "Nancy Davolio", Title = "Sales Representative", City = "Seattle " },
            new Employee { EmployeeID = 2, Name = "Andrew Fuller", Title = "Vice President, Sales", City = "Kirkland " },
            new Employee { EmployeeID = 3, Name = "Janet Leverling", Title = "Sales Representative", City = "Redmond " },
            new Employee { EmployeeID = 4, Name = "Margaret Peacock", Title = "Sales Representative", City = "London " },
            new Employee { EmployeeID = 5, Name = "Steven Buchanan", Title = "Sales Manager", City = "Tacoma " },
            new Employee { EmployeeID = 6, Name = "Michael Suyama", Title = "Sales Representative", City = "London " },
            new Employee { EmployeeID = 7, Name = "Robert King", Title = "Sales Representative", City = "London " },
            new Employee { EmployeeID = 8, Name = "Laura Callahan", Title = "Inside Sales Coordinator", City = "Seattle " },
            new Employee { EmployeeID = 9, Name = "Anne Dodsworth", Title = "Sales Representative", City = "London" } ,
            new Employee { EmployeeID = 10, Name = "James Franco", Title = "Sales Representative", City = " London" }
        };

        public ActionResult Index()
        {
            ViewBag.DataSource = Order;
            ViewBag.Employees = EmployeesData;
            return View();
        }

        public class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string City { get; set; }

        }
        public class OrderDetail
        {
            public int? OrderID { get; set; }
            public double? Freight { get; set; }
            public string ShipCity { get; set; }
            public string ShipName { get; set; }
            public int EmployeeID { get; set; }
        }
    }
}