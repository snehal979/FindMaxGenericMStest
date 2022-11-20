namespace FindMaxNum
{
    public class Tests
    {
        GenericClassOrMethod<string> GenericString = new GenericClassOrMethod<string>();
        /// <summary>
        /// Uc4_StringValue
        /// </summary>

        [Test]
        public void GenericGivenmaxfirststringValue_whenanalysed_shouldreturnfistmax()
        {


            string result = GenericString.GenericClass("Peach", "Apple", "Banana");

            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GenericGivenmaxSecondstringValue_whenanalysed_shouldreturnSecondmax()
        {

            string result = GenericString.GenericClass("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GenericGivenmaxStringValue_whenanalysed_shouldreturnThirdmax()
        {

            string result = GenericString.GenericClass("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", result);
        }


       

       






    }
}