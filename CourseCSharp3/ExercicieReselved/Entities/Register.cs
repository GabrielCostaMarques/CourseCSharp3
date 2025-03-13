namespace CourseCSharp3.ExercicieReselved.Entities
{
    internal class Register
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Register(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        //Implementando uma regra
        public override bool Equals(object? obj)
        {
            if (!(obj is Register)) return false;
            Register other = obj as Register;

            return Name.Equals(other.Name);
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
