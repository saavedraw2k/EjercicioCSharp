namespace EjercicioCSharp
{
    public abstract class Employee
    {
        private string _firstName;

        //Propiedades de una clase abstracta.
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public Boolean IsActive { get; set; }


        //Método abstracto.
        public abstract decimal GetValueToPay();

        //Sobreescritura de métodos.
        public override string ToString()
        {
            //Interpolacion
            return $"{Id} - {FirstName} {LastName}, " +
                    $"Birth: {BirthDate}, Hiring: {HiringDate}, " +
                    $"Is active: {IsActive}";
        }
    }
}
