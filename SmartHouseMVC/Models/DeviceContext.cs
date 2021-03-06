﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SmartHouseMVC.Models.SmartHouse.Devices;

namespace SmartHouseMVC.Models
{
    public class DeviceContext : DbContext
    {
        static DeviceContext()
        {
            Database.SetInitializer(new DeviceContextInitializer());
        }

        public DbSet<AirConditioner> AirConditioners { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<HomeCinema> HomeCinemas { get; set; }
        public DbSet<Loudspeakers> Loudspeakerses { get; set; }
        public DbSet<Tv> Tvs { get; set; }
    }
}