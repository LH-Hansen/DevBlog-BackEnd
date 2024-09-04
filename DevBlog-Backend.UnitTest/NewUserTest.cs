using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.UnitTest
{
    public class NewUserTest
    {
        [Fact]
        public void NewUser()
        {
            //Arrange
            string username = "username",
                   email = "email@email.com",
                   password = "P@ssw0rd";

            //Act
            User newUser = new User(username, email, password);

            //Assert
            Assert.True(newUser.Username == "username");
            Assert.True(newUser.Email == "email@email.com");
            Assert.True(newUser.Password == "P@ssw0rd");
        }
    }
}