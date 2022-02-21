namespace Core.Domain
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _personnelCode;

        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; }
        }
        public string LastName
        {
            get => _lastName;
            set { _lastName = value; }
        }
        public string DisplayName => $"{FirstName} {LastName} ";
        public int PersonnelCode
        {
            get => _personnelCode;
            set { _personnelCode = value; }
        }




    }
}
