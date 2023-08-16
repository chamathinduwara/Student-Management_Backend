using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Students.Any())
            {
                var students = new List<Student>()
                {
                    new Student()
                    {
                        FirstName = "Chamath",
                        LastName = "Induwara",
                        Mobile = "123456789",
                        Email = "chamathinduwara@gmail.com",
                        NIC = "982761897v",
                        DateOfBirth = new DateTime(1998, 10, 10),
                        Address = "Hatangala, Balangoda",
                    
                    },
                    new Student()
                    {
                        FirstName = "Emily",
                        LastName = "Johnson",
                        Mobile = "123-456-7890",
                        Email = "emily.j@example.com",
                        NIC = "1234567890",
                        DateOfBirth = new DateTime(1990, 5, 15),
                        Address = "123 Main St, Cityville, USA"
                    },
                    new Student()
                    {
                        FirstName = "David",
                        LastName = "Smith",
                        Mobile = "987-654-3210",
                        Email = "david.smith@example.com",
                        NIC = "9876543210",
                        DateOfBirth = new DateTime(1985, 9, 22),
                        Address = "456 Elm Rd, Townsville, USA"
                    },
                    new Student()
                    {
                        FirstName = "Sarah",
                        LastName = "Anderson",
                        Mobile = "555-123-4567",
                        Email = "sarah.a@example.com",
                        NIC = "4567890123",
                        DateOfBirth = new DateTime(1998, 12, 10),
                        Address = "789 Oak Ave, Villageland, USA"
                    },
                    new Student()
                    {
                        FirstName = "Michael",
                        LastName = "Williams",
                        Mobile = "111-222-3333",
                        Email = "michael.w@example.com",
                        NIC = "7654321098",
                        DateOfBirth = new DateTime(1982, 3, 29),
                        Address = "234 Birch Ln, Hamletville, USA"
                    },
                    new Student()
                    {
                        FirstName = "Jessica",
                        LastName = "Brown",
                        Mobile = "444-555-6666",
                        Email = "jessica.b@example.com",
                        NIC = "2345678901",
                        DateOfBirth = new DateTime(1995, 7, 18),
                        Address = "567 Pine St, Meadowtown, USA"
                    },
                    new Student()
                    {
                        FirstName = "Christopher",
                        LastName = "Martinez",
                        Mobile = "777-888-9999",
                        Email = "chris.m@example.com",
                        NIC = "6789012345",
                        DateOfBirth = new DateTime(1993, 11, 5),
                        Address = "890 Maple Dr, Riverside, USA"
                    },
                    new Student()
                    {
                        FirstName = "Amanda",
                        LastName = "Davis",
                        Mobile = "222-333-4444",
                        Email = "amanda.d@example.com",
                        NIC = "3456789012",
                        DateOfBirth = new DateTime(1989, 2, 3),
                        Address = "123 Cedar Rd, Lakeside, USA"
                    },
                    new Student()
                    {
                        FirstName = "John",
                        LastName = "Wilson",
                        Mobile = "888-999-0000",
                        Email = "john.w@example.com",
                        NIC = "5678901234",
                        DateOfBirth = new DateTime(1980, 8, 12),
                        Address = "456 Oak St, Mountainville, USA"
                    },
                    new  Student()
                    {
                        FirstName = "Melissa",
                        LastName = "Taylor",
                        Mobile = "333-444-5555",
                        Email = "melissa.t@example.com",
                        NIC = "4567890123",
                        DateOfBirth = new DateTime(1991, 6, 27),
                        Address = "789 Elm Ave, Beachside, USA"
                    },
                    new Student()
                    {
                        FirstName = "Daniel",
                        LastName = "Anderson",
                        Mobile = "555-666-7777",
                        Email = "daniel.a@example.com",
                        NIC = "7890123456",
                        DateOfBirth = new DateTime(1987, 4, 14),
                        Address = "234 Maple Rd, Countryside, USA"
                    }

                };
                dataContext.Students.AddRange(students);
                dataContext.SaveChanges();
            }
        }

    }
}

