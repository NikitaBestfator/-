namespace КТ2;

public class Wizard : Hero, IMagicUser //почему ошибка
{
    public Wizard(string name, int level) : base(name, level)
    {
        
    }

    protected override ConsoleColor Color => ConsoleColor.DarkMagenta;

    public override void UseAbility()
    {
        Write($"{nameof(IMagicUser)}: Использован огненный шар");
        
    }

    public void CastSpell()
    {
        Write($"{nameof(IMagicUser)}: Прочитано заклинание");
    }
}