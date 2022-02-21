using Core.Domain;
using Core.Services;

namespace OrganisationChart.Services
{
    public class PeyvastChartServices : IOChartServices
    {
        public Employee GetEmployee(int personnelCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(string personnelName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(Position position)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(OrganisationUnit organisationUnit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(OChartEnums.Location location)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(Department department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetInferiorEmployees(OrganisationUnit organisationUnit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetInferiorEmployees(int personnelCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetInferiorEmployees(string personnelName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganisationUnit> GetInferiorOrganisationUnits(OrganisationUnit organisationUnit, int numberOfHops)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganisationUnit> GetSiblingOrganisationUnits(OrganisationUnit organisationUnit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetSuperiorEmployees(OrganisationUnit organisationUnit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetSuperiorEmployees(int personnelCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetSuperiorEmployees(string personnelName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganisationUnit> GetSuperiorOrganisationUnits(OrganisationUnit organisationUnit, int numberOfHops)
        {
            throw new NotImplementedException();
        }
    }
}
