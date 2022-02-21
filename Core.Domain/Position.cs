namespace Core.Domain
{
    /// <summary>
    /// جایگاه شغلی
    /// </summary>
    public class Position
    {
        private int _code;
        private string? _name;

        /// <summary>
        /// نام جایگاه شغلی
        /// </summary>
        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        /// <summary>
        /// کد جایگاه شغلی
        /// </summary>
        public int Code
        {
            get => _code;
            set { _code = value; }
        }
    }
}
