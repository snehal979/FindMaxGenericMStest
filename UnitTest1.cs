namespace FindMaxNum
{
    public class Tests
    {
        GenericMethod genericMethod = new GenericMethod();
        /// <summary>
        /// Uc5_IntergerValue
        /// </summary>

        [Test]
        public void GMethodGivenmaxfirstname_whenanalysed_shouldreturnfistmax()
        {


            int result = genericMethod.FindMax(30, 2, 5);

            Assert.AreEqual(30, result);
        }
        [Test]
        public void GMethodGivenmaxSecondname_whenanalysed_shouldreturnSecondmax()
        {

            int result = genericMethod.FindMax(3, 30, 5);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void GMethodGivenmaxThirdname_whenanalysed_shouldreturnThirdmax()
        {

            int result = genericMethod.FindMax(3, 5, 30);
            Assert.AreEqual(30, result);
        }











    }
}