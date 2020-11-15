using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               Id = 1,
               Name = "Mahmoud",
               Department = Dept.IT,
               Email = "mahmmuod.b2010@gmail.com"
           },
            new Employee
            {
                Id = 2,
                Name = "Aya",
                Department = Dept.HR,
                Email = "Aya.b2010@gmail.com"
            }
           );
        }
    }
}
