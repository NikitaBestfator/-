namespace КТ2;

public static class GameSetting
{
    static int MaxLevel = 100;

    public static Boolean IsLevelValid(int level)//почему ругается
    {
        return level <= MaxLevel;
    }
}