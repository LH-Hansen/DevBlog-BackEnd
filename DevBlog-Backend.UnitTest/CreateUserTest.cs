using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.UnitTest
{
    public class CreateUserTest
    {
        [Fact]
        public void CreateUserTestConstructor()
        {
            //Arrange
            User newUser = new User("username", "email@email.com", "P@ssw0rd");

            //Act
            User user = newUser;

            //Assert
            Assert.True(user.Username == "username");
            Assert.True(user.Email == "email@email.com");
            Assert.True(user.Password == "P@ssw0rd");
        }
    }
}