namespace DevBlog_Backend.UnitTest
{
    public class CreateUserTest
    {
        public readonly IUserRepository _userRepository;

        public CreateUserTest(IUserRepository userRepository)
        { _userRepository = userRepository; }

        [Fact]
        public void CreateUserRepository()
        {
            //Arrange
            User newUser = new("username", "email@email.com", "P@ssw0rd");

            //Act
            bool result = _userRepository.CreateUser(newUser);

            //Assert
            Assert.True(result == true);
        }
    }
}