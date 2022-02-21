using System.ComponentModel.DataAnnotations;
using static Core.Domain.OChartEnums;

namespace Core.Domain
{
    public class Employee
    {

        private Person _person;
        private IEnumerable<Tuple<Position, OrganisationUnit, Status>> _worked_As;
        /// <summary>
        /// اطلاعات شخصی پرسنل
        /// </summary>
        [Required]
        public Person Person
        {
            get => _person;
            set { _person = value; }
        }
        /// <summary>
        /// Tuple<"سمت سازمانی", "واحد سازمانی", "وضعیت فعال بودن در این جایگاه">
        /// </summary>
        public IEnumerable<Tuple<Position, OrganisationUnit, Status>> Worked_As
        {
            get => _worked_As;
            set { _worked_As = value; }
        }

    }
}
