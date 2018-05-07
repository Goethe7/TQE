namespace Travel
{
    public class Proposer
    {
        int _age;
        Gender _gender;

        public Proposer()
        {

        }

        public Proposer(int age, Gender gender)
        {
            _age = age;
            _gender = gender;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

    }
}
