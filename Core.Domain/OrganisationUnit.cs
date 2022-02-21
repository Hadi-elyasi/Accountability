using static Core.Domain.OChartEnums;

namespace Core.Domain;

/// <summary>
/// حایگاه سازمانی
/// </summary>
public class OrganisationUnit
{
    private int _code;
    private string? _name;
    private OrganisationUnit? _subset_Of;
    private Department? department;
    private Location _location;

    /// <summary>
    /// نام واحد سازمانی
    /// </summary>
    public string Name
    {
        get => _name;
        set { _name = value; }
    }
    /// <summary>
    /// کد واحد سازمانی
    /// </summary>
    public int Code
    {
        get => _code;
        set { _code = value; }
    }
    /// <summary>
    /// واحد سازمانی مافوق
    /// </summary>
    public OrganisationUnit Subset_Of
    {
        get => _subset_Of;
        set { _subset_Of = value; }
    }

    /// <summary>
    /// دپارتمان واحد سازمانی
    /// </summary>
    public Department Department
    {
        get => department;
        set { department = value; }
    }
    /// <summary>
    /// جایگاه واحد سازمانی: منطقه، ستاد و یا شعبه
    /// </summary>
    public Location Location
    {
        get => _location;
        set { _location = value; }
    }
}

