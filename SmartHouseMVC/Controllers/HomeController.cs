﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartHouseMVC.Attributes;
using SmartHouseMVC.Models;

namespace SmartHouseMVC.Controllers
{
    public class HomeController : Controller
    {
        DeviceListModel model = new DeviceListModel();
        
        public ActionResult Index()
        {
            return View(model.GetDevices());
        }

        [HttpPost]
        [MultipleButton(Name = "add", Argument = "AirConditioner")]
        public ActionResult AddAirConditioner()
        {
            model.Add("conditioner");
            return RedirectToAction("Index");
        }
    }
}