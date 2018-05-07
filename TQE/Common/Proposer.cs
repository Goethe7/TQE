namespace TQE.Common
{
    public class Proposer
    {
        public Proposer()
        {

        }

        public Proposer(int age, Gender gender)
        {
            this.Age = age;
            this.Gender = gender;
        }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}
