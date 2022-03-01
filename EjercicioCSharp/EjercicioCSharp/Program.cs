using EjercicioCSharp;

Console.WriteLine("Conceptos de POO");
Console.WriteLine("=================");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Gabriel",
    LastName = "Saavedra",
    BirthDate = new Date(1987, 4, 14),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 25000M //Constante decimal postfijo 'M'
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2015,
    FirstName = "Jesus",
    LastName = "Moreno",
    BirthDate = new Date(1979, 7, 10),
    HiringDate = new Date(2019, 2, 20),
    IsActive = true,
    Sales = 100000M,
    CommissionPercentage = 0.03F
    
};

Console.WriteLine(employee2);