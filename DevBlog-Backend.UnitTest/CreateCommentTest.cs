using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.UnitTest
{
    public class CreateCommentTest
    {
        [Fact]
        public void CreateComment()
        {
            //Arrange
            User user = new User("user", "user@email.com", "P@ssw0rd");
            Comment newComment = new Comment(user, "Body");

            //Act
            Comment comment = newComment;

            //Assert
            Assert.True(comment.Body == "Body");
            Assert.True(comment.Author == user);
        }
    }
}