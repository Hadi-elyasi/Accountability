namespace Core.Domain
{
    public class OChartEnums
    {
        /// <summary>
        /// جایگاه واحد سازمانی
        /// </summary>
        public enum Location
        {
            /// <summary>
            /// ستاد
            /// </summary>
            Headquarters = 1,
            /// <summary>
            /// منطقه
            /// </summary>
            Region = 2,
            /// <summary>
            /// شعبه
            /// </summary>
            Branch = 3
        }
        /// <summary>
        /// وضعیت کارمند
        /// </summary>
        public enum Status
        {
            /// <summary>
            /// فعال
            /// </summary>
            Active = 1,
            /// <summary>
            /// عیرفعال
            /// </summary>
            Inactive = 2,
        }
    }
}
