using AdventureGame;
using NUnit.Framework;

namespace AdventureGame.Tests
{
    public class Tests
    {
        Player testPlayer;
        Enemy testEnemy;

        [SetUp]
        public void Setup()
        {
            testEnemy = new Enemy();
        }

        [Test]
        public void PlayerWithZeroAttack_Attack_NoDamage()
        {
            // Arrange
            testPlayer = new Player(20000, 0);
            double enemyOriginalHP = testEnemy.Health;
            // Act
            bool success = testPlayer.Attack(testEnemy);

            // Assert
            Assert.That(success, Is.False);
            Assert.That(testEnemy.Health, Is.EqualTo(enemyOriginalHP));
        }


    }
}