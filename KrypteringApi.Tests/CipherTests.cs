using KrypteringApi; // Ger tillgång till CipherService

namespace KrypteringApi.Tests
{
    public class CipherTests
    {
        [Fact]
        public void Encrypt_ShouldShiftCharactersCorrectly()
        {
            // Arrange 
            var service = new CipherService();
            var input = "ABC";
            var shift = 1;

            // Act 
            var result = service.Encrypt(input, shift);

            // Assert 
            Assert.Equal("BCD", result);
        }

        [Fact]
        public void Decrypt_ShouldReverseEncryption()
        {
            // Arrange
            var service = new CipherService();
            var input = "BCD";
            var shift = 1;

            // Act
            var result = service.Decrypt(input, shift);

            // Assert
            Assert.Equal("ABC", result);
        }
    }
}