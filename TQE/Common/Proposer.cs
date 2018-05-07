namespace TQE.Common
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
            this._age = age;
            this._gender = gender;
        }

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        public Gender Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

    }
}
