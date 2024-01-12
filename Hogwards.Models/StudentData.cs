using Hogwards.Models;

public class StudentData
{
    public IQueryable<Student> Students;

    public StudentData()
    {

    }

    public IQueryable<Student> GetStudents()
    {
        Students = new[]
        {
            new Student
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Age = 12,
                Gender = "male",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Peter",
                Age = 15,
                Gender = "male",
                House = new House
                {
                    Id = 2,
                    Name = "Gryffindor"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Rosy",
                Age = 13,
                Gender = "female",
                House = new House
                {
                    Id = 3,
                    Name = "Hufflepuff"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "June",
                Age = 25,
                Gender = "male",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Smith",
                Age = 25,
                Gender = "male",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Rita",
                Age = 20,
                Gender = "male",
                House = new House
                {
                    Id = 2,
                    Name = "Gryffindor"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Hardy",
                Age = 20,
                Gender = "male",
                House = new House
                {
                    Id = 3,
                    Name = "Hufflepuff"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Tom",
                Age = 14,
                Gender = "male",
                House = new House
                {
                    Id = 4,
                    Name = "Gryffindor"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Age = 20,
                Gender = "male",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Timothy",
                Age = 13,
                Gender = "female",
                House = new House
                {
                    Id = 2,
                    Name = "Gryffindor"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Tim",
                Age = 15,
                Gender = "male",
                House = new House
                {
                    Id = 3,
                    Name = "Hufflepuff"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Carry",
                Age = 20,
                Gender = "female",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Christina",
                Age = 18,
                Gender = "male",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Megan",
                Age = 19,
                Gender = "female",
                House = new House
                {
                    Id = 2,
                    Name = "Gryffindor"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Agon",
                Age = 16,
                Gender = "male",
                House = new House
                {
                    Id = 3,
                    Name = "Hufflepuff"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Harry",
                Age = 15,
                Gender = "male",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Harold",
                Age = 17,
                Gender = "male",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Junjy",
                Age = 15,
                Gender = "female",
                House = new House
                {
                    Id = 1,
                    Name = "Slytherin"
                }
            },new Student
            {
                Id = Guid.NewGuid(),
                Name = "Jimmy",
                Age = 11,
                Gender = "male",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Fiza",
                Age = 16,
                Gender = "female",
                House = new House
                {
                    Id = 3,
                    Name = "Hufflepuff"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Diana",
                Age = 14,
                Gender = "female",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Richard",
                Age = 17,
                Gender = "male",
                House = null
            },
             new Student
            {
                Id = Guid.NewGuid(),
                Name = "Suzee",
                Age = 18,
                Gender = "female",
                House = new House
                {
                    Id = 4,
                    Name = "Ravenclaw"
                }
            },
            new Student
            {
                Id = Guid.NewGuid(),
                Name = "Amima",
                Age = 20,
                Gender = "female",
                House = null
            }

        }.AsQueryable();

        return Students;
    }
}