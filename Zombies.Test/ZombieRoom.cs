namespace Zombies.Test;

public class ZombieRoom
{
    [Fact]
    public void IsFull_ReturnsTrue_When_CapacityIsFull()
    {
        // Arrange
        var room = new ZombieRoom();

        // Act
        var result = room.isFull;
        // Assert
        result.Should().BeTrue();

    }
}