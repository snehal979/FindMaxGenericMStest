namespace FindMaxNum
{
    public class Tests
    {
        FindMaxNumber maxNum = new FindMaxNumber();
        /// <summary>
        /// Uc2_1
        /// </summary>
        [Test]
        public void GivenMaxfirstname_whenanalysed_shouldReturnfistmax()
        {
            

            float result = maxNum.FindMaxFloat(30.8F, 2.9F, 5.6F);
           
            Assert.AreEqual(30.8, result);
        }
        /// <summary>
        /// Uc2_2
        /// </summary>
        [Test]
        public void GivenMaxSecondname_whenanalysed_shouldReturnSecondmax()
        {


            float result = maxNum.FindMaxFloat(2.9F, 30.8F, 5.6F);

            Assert.AreEqual(30.8, result);
        }
        /// <summary>
        /// Uc2_3
        /// </summary>
        [Test]
        public void GivenMaxThirdname_whenanalysed_shouldReturnThirdmax()
        {


            float result = maxNum.FindMaxFloat(5.8F, 2.9F, 30.8F);

            Assert.AreEqual(30.8, result);
        }



    }
}