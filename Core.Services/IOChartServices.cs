using Core.Domain;
using static Core.Domain.OChartEnums;

namespace Core.Services
{
    public interface IOChartServices
    {
        #region Employees
        Employee GetEmployee(int personnelCode);
        IEnumerable<Employee> GetEmployees(string personnelName);
        IEnumerable<Employee> GetEmployees(Position position);
        IEnumerable<Employee> GetEmployees(OrganisationUnit organisationUnit);
        IEnumerable<Employee> GetEmployees(Location location);
        IEnumerable<Employee> GetEmployees(Department department);


        #region Superior/inferior Employees
        IEnumerable<Employee> GetSuperiorEmployees(OrganisationUnit organisationUnit);
        IEnumerable<Employee> GetSuperiorEmployees(int personnelCode);
        IEnumerable<Employee> GetSuperiorEmployees(string personnelName);

        IEnumerable<Employee> GetInferiorEmployees(OrganisationUnit organisationUnit);
        IEnumerable<Employee> GetInferiorEmployees(int personnelCode);
        IEnumerable<Employee> GetInferiorEmployees(string personnelName);

        #endregion

        #region Organisation

        /// <summary>
        /// numberOfHops=-1 ==> return whole of the units till to Root
        /// </summary>
        /// <param name="organisationUnit"></param>
        /// <param name="numberOfHops"></param>
        /// <returns></returns>
        IEnumerable<OrganisationUnit> GetSuperiorOrganisationUnits(OrganisationUnit organisationUnit, int numberOfHops);
        /// <summary>
        /// numberOfHops=-1 ==> return whole of the units till to the deepest leaf
        /// </summary>
        /// <param name="organisationUnit"></param>
        /// <param name="numberOfHops"></param>
        /// <returns></returns>
        IEnumerable<OrganisationUnit> GetInferiorOrganisationUnits(OrganisationUnit organisationUnit, int numberOfHops);

        IEnumerable<OrganisationUnit> GetSiblingOrganisationUnits(OrganisationUnit organisationUnit);


        #endregion

        #endregion
    }
}
