using NUnit.Framework;
using WedDesign_Final_RyanWall.Services;
using WedDesign_Final_RyanWall.Models;


namespace UserServiceTest
{
    [TestFixture]
    public class UnitTest2
    {
        private ICoolRatingService coolratingservice;

        [SetUp]
        public void SetUp()
        {
            coolratingservice = new CoolRatingService();
        }


        [TestCase]
        public void Test1()
        {
            Assert.IsTrue(true);
        }

        [TestCase]
        public void WhenYourFirstNameStartsWithLetterRRatingShouldBe100()
        {
            // Arrange
            var person = new Person();
            person.FirstName = "Ryan";
            var expectedRating = 100;

            // Act
            var rating = coolratingservice.GetCoolRating(person);

            // Assert
            Assert.AreEqual(expectedRating, rating);
        }






    }
}
