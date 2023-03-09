using HRM_Humman.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM_Humman.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HRM_HummanContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HRM_HummanContext>>()))
            {
                if (context.Employee.Any())
                {
                    return;
                }

                var employees = new Employee[]
                {
                    new Employee { FullName = "John Smith", Department = "IT", Salary = 5000, Email = "john.smith@company.com", Phone = "555-1234", Address = "123 Main St", JoinDate = new DateTime(2022, 1, 1) },
                    new Employee { FullName = "Mary Johnson", Department = "HR", Salary = 6000, Email = "mary.johnson@company.com", Phone = "555-5678", Address = "456 Elm St", JoinDate = new DateTime(2022, 2, 1) },
                    new Employee { FullName = "Robert Lee", Department = "Finance", Salary = 7000, Email = "robert.lee@company.com", Phone = "555-9012", Address = "789 Oak St", JoinDate = new DateTime(2022, 3, 1) },
                    new Employee { FullName = "Julia Williams", Department = "Marketing", Salary = 5500, Email = "julia.williams@company.com", Phone = "555-3456", Address = "321 Maple Ave", JoinDate = new DateTime(2022, 4, 1) },
                    new Employee { FullName = "David Brown", Department = "IT", Salary = 8000, Email = "david.brown@company.com", Phone = "555-7890", Address = "654 Pine St", JoinDate = new DateTime(2022, 5, 1) },
                    new Employee { FullName = "Karen Taylor", Department = "HR", Salary = 6500, Email = "karen.taylor@company.com", Phone = "555-2345", Address = "987 Cedar Ave", JoinDate = new DateTime(2022, 6, 1) },
                    new Employee { FullName = "Michael Johnson", Department = "Finance", Salary = 7500, Email = "michael.johnson@company.com", Phone = "555-6789", Address = "654 Oak St", JoinDate = new DateTime(2022, 7, 1) },
                    new Employee { FullName = "Sarah Davis", Department = "Marketing", Salary = 6000, Email = "sarah.davis@company.com", Phone = "555-1234", Address = "321 Elm St", JoinDate = new DateTime(2022, 8, 1) },
                    new Employee { FullName = "William Wilson", Department = "IT", Salary = 9000, Email = "william.wilson@company.com", Phone = "555-5678", Address = "987 Pine St", JoinDate = new DateTime(2022, 9, 1) },
                    new Employee { FullName = "Elizabeth Clark", Department = "HR", Salary = 7000, Email = "elizabeth.clark@company.com", Phone = "555-9012", Address = "456 Oak St", JoinDate = new DateTime(2022, 10, 1) },
                    new Employee { FullName = "James Baker", Department = "Finance", Salary = 8000, Email = "james.baker@company.com", Phone = "555-3456", Address = "123 Cedar Ave", JoinDate = new DateTime(2022, 11, 1) },
                    new Employee { FullName = "Emily Anderson", Department = "IT", Salary = 5500, Email = "emily.anderson@company.com", Phone = "555-2345", Address = "789 Maple Ave", JoinDate = new DateTime(2022, 12, 1) },
                    new Employee { FullName = "Daniel Garcia", Department = "HR", Salary = 6500, Email = "daniel.garcia@company.com", Phone = "555-6789", Address = "321 Oak St", JoinDate = new DateTime(2023, 1, 1) },
                    new Employee { FullName = "Ava Hernandez", Department = "Finance", Salary = 7500, Email = "ava.hernandez@company.com", Phone = "555-1234", Address = "654 Cedar Ave", JoinDate = new DateTime(2023, 2, 1) },
                    new Employee { FullName = "Alexander Martinez", Department = "Marketing", Salary = 6000, Email = "alexander.martinez@company.com", Phone = "555-5678", Address = "987 Pine St", JoinDate = new DateTime(2023, 3, 1) },
                    new Employee { FullName = "Mia Lopez", Department = "IT", Salary = 8500, Email = "mia.lopez@company.com", Phone = "555-9012", Address = "456 Maple Ave", JoinDate = new DateTime(2023, 4, 1) },
                    new Employee { FullName = "Noah Gonzalez", Department = "HR", Salary = 7000, Email = "noah.gonzalez@company.com", Phone = "555-3456", Address = "123 Elm St", JoinDate = new DateTime(2023, 5, 1) },
                    new Employee { FullName = "Sophia Perez", Department = "Finance", Salary = 8000, Email = "sophia.perez@company.com", Phone = "555-7890", Address = "789 Pine St", JoinDate = new DateTime(2023, 6, 1) },
                    new Employee { FullName = "Ethan Sanchez", Department = "Marketing", Salary = 5500, Email = "ethan.sanchez@company.com", Phone = "555-2345", Address = "654 Oak St", JoinDate = new DateTime(2023, 7, 1) },
                    new Employee { FullName = "Isabella Rivera", Department = "IT", Salary = 9000, Email = "isabella.rivera@company.com", Phone = "555-6789", Address = "321 Cedar Ave", JoinDate = new DateTime(2023, 8, 1) }

                    // Add more employees here
                };

                context.Employee.AddRange(employees);
                context.SaveChanges();
                
            }
        }
    }
}
