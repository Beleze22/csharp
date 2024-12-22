namespace Crud.Models;

public class CrudModel
{
    public CrudModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; init; }  
    public string Name { get; private set; }
}