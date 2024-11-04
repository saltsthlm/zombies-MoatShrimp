namespace Zombies;

public class ZombieRoom
{
    private int _capacity;

    public bool IsFull => true;

    public ZombieRoom(int capacity)
    {
        _capacity = capacity;
    }
}
