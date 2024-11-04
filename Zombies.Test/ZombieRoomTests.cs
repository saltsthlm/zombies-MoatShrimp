namespace Zombies.Test;

public class ZombieRoomTests
{
    [Fact]
    public void Room_WithNoCapacity_IsFull()
    {
        // Arrange
        var room = new ZombieRoom(0);

        // Act
        var result = room.IsFull;

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void Room_ThatFitsOneZombie_IsNotFull()
    {
    }

    [Fact]
    public void Room_WithNoCapacity_CannotAddZombies()
    {
    }

    [Fact]
    public void Room_WithSpaceForOne_IsFull_WhenOneZombieIsAdded()
    {
    }

    [Fact]
    public void Room_WithSpaceForTwo_IsNotFull_WhenOneZombieIsAdded()
    {
    }

    [Fact]
    public void Room_WithSpaceForTOne_Has_SecondZombieEatTheFirstZombie_WhenAdded()
    {
    }
}
