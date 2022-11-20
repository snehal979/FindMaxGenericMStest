namespace FindMaxNum
{
    public class Tests
    {
        GenericClassOrMethod<float> GenericFloat = new GenericClassOrMethod<float>();
        /// <summary>
        /// Uc4_FloatValue
        /// </summary>

        [Test]
        public void GenericGivenmaxfirstFloatValue_whenanalysed_shouldreturnfistmax()
        {


            float result = GenericFloat.GenericClass(30.7F, 2.7F, 5.4F);

            Assert.AreEqual(30.7F, result);
        }
        [Test]
        public void GenericGivenmaxSecondFloatValue_whenanalysed_shouldreturnSecondmax()
        {

            float result = GenericFloat.GenericClass(2.7F, 30.7F, 5.4F);
            Assert.AreEqual(30.7F, result);
        }
        [Test]
        public void GenericGivenmaxFloatValue_whenanalysed_shouldreturnThirdmax()
        {

            float result = GenericFloat.GenericClass(2.7F, 5.4F, 30.7F);
            Assert.AreEqual(30.7F, result);
        }


       

       






    }
}