using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
 public partial class StudInfoSys1Context
 {
        public StudInfoSys1Context()
        {
            
        }
        //sleepy :)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1GR3ORS\\SQLEXPRESS01;Initial Catalog=StudInfoSys1; Integrated Security = True; Trust Server Certificate = True;");
        }
        
    }
}

