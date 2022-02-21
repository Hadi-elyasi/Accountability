namespace Core.Domain
{
    public class Department
    {
        private string? _name;
        private int _code;

        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        public int Code
        {
            get => _code;
            set { _code = value; }
        }
    }
}
