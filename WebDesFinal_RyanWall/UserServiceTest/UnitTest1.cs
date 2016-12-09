
using NUnit.Framework;
using WedDesign_Final_RyanWall.Services;
using WedDesign_Final_RyanWall.Models;

namespace UserServiceTest.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private ICoolRatingService coolratingservice;
        private IUserService userservice;

        [SetUp]
        public void SetUp()
        {
            coolratingservice = new CoolRatingService();
            userservice = new UserService(coolratingservice);

        }

        [TestCase]
        public void CoolRatingIsBelowThresholdTheUserIsNotCool()
        {
            var person = new Person
            {
                FirstName = "frank",
                LastName = "cool",
                EmailAddress = "coolness@gmail.com",
                NickName = "speedy",
                HouseAddress = "998 cool st",
                Description = "I Am Cool",
                DoYouPlayVG = false
                
          
                
            };

            var result = userservice.UserIsCool(person);

            Assert.IsFalse(result);
        }
    }
}
