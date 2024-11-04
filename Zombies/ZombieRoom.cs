namespace Zombies;

public class ZombieRoom
{
    private int _capacity;

    public bool isFull => true;

    public ZombieRoom(int capacity)
    {
        _capacity = capacity;
    }
}
