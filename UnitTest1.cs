namespace FindMaxNum
{
    public class Tests
    {
        GenericClassOrMethod<int> genericClass = new GenericClassOrMethod<int>(30,5,2);
        /// <summary>
        /// Uc4_IntergerValue
        /// </summary>
        [Test]
        public void GMethodGivenmaxfirstname_whenanalysed_shouldreturnfistmax()
        {
            int result = genericClass.GenericClass(30, 2, 5);

            Assert.AreEqual(30, result);
        }
        
        [Test]
        public void GMethodGivenmaxSecondname_whenanalysed_shouldreturnSecondmax()
        {

            int result = genericClass.GenericClass(3, 30, 5);
            Assert.AreEqual(30, result);
        }
       
        [Test]
        public void GMethodGivenmaxThirdname_whenanalysed_shouldreturnThirdmax()
        {

            int result = genericClass.GenericClass(3, 5, 30);
            Assert.AreEqual(30, result);
        }






    }
}