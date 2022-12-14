namespace WorkshopAspNetCoreMvc.Models;

public class Department
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public bool Status { get; private set; }

    public Department() { }

    public Department(int id, string name, bool status)
    {
        Id = id;
        Name = name;
        Status = status;
    }
}