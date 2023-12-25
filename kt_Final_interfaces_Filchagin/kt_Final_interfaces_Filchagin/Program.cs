using kt_Final_interfaces_Filchagin;
using System.Numerics;

internal static class Program
{
    public static void Main()
    {
        World world = new World(7);

        world.AddEnemy(new Position(0,0), new Enemy("Enemy",10,100,3,3,2,28));
        world.AddTower(new Position(0, 0), new Tower("Tower",13,50,1,1,1));
    
        while (true)
        {
            Thread.Sleep(1000);
            world.WorldUpdate();
        }
    }
}
