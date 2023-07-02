using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LENOVO\\SQLEXPRESS01; initial catalog=HotelReservationProjectDb; Integrated Security=true;");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
    }
}
