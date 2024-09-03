using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.UnitTest
{
    public class CreateUserTest
    {
        [Fact]
        public void CreateUser()
        {
            //Arrange
            User newUser = new User("username", "email@email.com", "P@ssw0rd");

            //Act
            User user = newUser;

            //Assert
            Assert.True(user.Username == "username");
        }
    }
}