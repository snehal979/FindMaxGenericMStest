namespace FindMaxNum
{
    public class Tests
    {
        GenericMethod genericMethod = new GenericMethod();
        /// <summary>
        /// Uc5_FloatValue
        /// </summary>

        [Test]
        public void GMethodGivenmaxfirstFloatValue_whenanalysed_shouldreturnfistmax()
        {


            float result = genericMethod.FindMax(30.7F, 2.7F, 5.4F);

            Assert.AreEqual(30.7F, result);
        }
        [Test]
        public void GMethodGivenmaxSecondFloatValue_whenanalysed_shouldreturnSecondmax()
        {

            float result = genericMethod.FindMax(2.7F, 30.7F, 5.4F);
            Assert.AreEqual(30.7F, result);
        }
        [Test]
        public void GMethodGivenmaxFloatValue_whenanalysed_shouldreturnThirdmax()
        {

            float result = genericMethod.FindMax(2.7F, 5.4F, 30.7F);
            Assert.AreEqual(30.7F, result);
        }









    }
}