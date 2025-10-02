namespace Library21.Test
{
    public class PasswordValidatorTest
    {
        [Theory]
        [InlineData("123", false)]
        [InlineData("", false)]
        [InlineData("password123", true)]
        public void IsValid_Theory(string password,bool expected)
        {
            Assert.Equal(expected, PasswordValidator.IsValid(password));
        }
    }
}