namespace FindMaxNum
{
    public class Tests
    {
        GenericMethod genericMethod = new GenericMethod();
        /// <summary>
        /// Uc5_StringValue
        /// </summary>

        [Test]
        public void GMethodGivenmaxfirstStringValue_whenanalysed_shouldreturnfistmax()
        {

            string result = genericMethod.FindMax("Peach", "Apple", "Banana");

            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GMethodGivenmaxSecondStringValue_whenanalysed_shouldreturnfistmax()
        {


            string result = genericMethod.FindMax("Apple", "Peach", "Banana");


            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GMethodGivenmaxTHIRDStringValue_whenanalysed_shouldreturnfistmax()
        {

            string result = genericMethod.FindMax("Banana", "Apple", "Peach");

            Assert.AreEqual("Peach", result);
        }









    }
}