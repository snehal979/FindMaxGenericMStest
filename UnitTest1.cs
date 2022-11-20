namespace FindMaxNum
{
    public class Tests
    {
        FindMaxNumber maxNum = new FindMaxNumber();
        /// <summary>
        /// Uc3_1
        /// </summary>
        [Test]
        public void GivenMaxfirstname_whenanalysed_shouldReturnfistmax()
        {


            String result = maxNum.FindMaxString("Peach", "Apple", "Banana");
           
            Assert.AreEqual("Peach", result);
        }
        /// <summary>
        /// Uc3_2
        /// </summary>
        [Test]
        public void GivenMaxSecondname_whenanalysed_shouldReturnSecondmax()
        {


            String result = maxNum.FindMaxString("Apple", "Peach", "Banana");

            Assert.AreEqual("Peach", result);
        }
        /// <summary>
        /// Uc3_3
        /// </summary>
        [Test]
        public void GivenMaxThirdname_whenanalysed_shouldReturnThirdmax()
        {


            String result = maxNum.FindMaxString("Banana", "Apple", "Peach");

            Assert.AreEqual("Peach", result);
        }



    }
}