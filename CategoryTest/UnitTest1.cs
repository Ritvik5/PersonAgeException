using PersonAgeException;

namespace CategoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenAge_ShouldReturn_ValidCategory()
        {
            //Arrange
            PersonAge obj = new PersonAge(26);

            //Act
            string result = obj.GetAge();

            //Assert
            Assert.AreEqual("Adults", result);
        }

        //[TestMethod]
        //public void GivenNullAge_ShouldReturn_Exception()
        //{
        //    try
        //    {
        //        //Arrange
        //        int age = default;
        //        PersonAge obj = new PersonAge(age);

        //        //Act
        //        string result = obj.GetAge();
        //    }
        //    catch(Exception ex)
        //    {
        //        //Assert
        //        Assert.AreEqual(ex.Message, "Age cannot be null");
        //    }
        //}

        [TestMethod]
        public void GivenNullAge_ShouldReturn_Exception()
        {
            int age = 10000;
            try
            {
                PersonAge obj = new PersonAge(Convert.ToInt32(age));
                string reult = obj.GetAge();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Age cannot be Empty");
                
            }
        }
    }
}