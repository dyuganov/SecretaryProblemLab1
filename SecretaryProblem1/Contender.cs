namespace SecretaryProblem1;

public class Contender
{
    private String Name { get; set; }
    
    private String Surname { get; set; }
    
    private int Value
    {
        get => Value;
        set
        {
            if (value > 0)
            {
                this.Value = value;
            }
        }
        
    }
    
    public Contender(string name, string surname, int value)
    {
        Name = name;
        Surname = surname;
        Value = value;
    }
}