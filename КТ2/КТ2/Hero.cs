namespace КТ2;

public abstract class Hero
{
    
    public string Name =>  _name;
    private string _name;

    public int Level => _level;
    private int _level;

    protected abstract ConsoleColor Color { get; }
    
    protected void Write(string message)
    {
        var tmpClr = Console.ForegroundColor;
        Console.ForegroundColor = Color;
        Console.WriteLine(message);
        Console.ForegroundColor = tmpClr;
    }

    public abstract void UseAbility();

    protected Hero(string name, int level)
    {
        _name = name;
        _level = level;
    }
    
    public void LevelUp()
    {
        if (GameSetting.IsLevelValid(_level + 1))
        {
            _level++;
        }
    }
    
}
public interface IMagicUser
{ 
    void CastSpell();
}

public interface IPhysicalFighter
{
    void Attack();
}