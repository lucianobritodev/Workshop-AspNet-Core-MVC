using System.Diagnostics.CodeAnalysis;

namespace workshop_asp_net_core_mvc.Models;

public class Department
{
    public int _id { get; private set; }
    public string _name { get; private set; }
    public bool _status { get; private set; }
    
    public Department() { }

    public Department(int id, string name, bool status)
    {
        _id = id;
        _name = name;
        _status = status;
    }
}