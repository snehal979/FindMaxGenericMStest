namespace FindMaxNum
{
    public class Tests
    {
        FindMaxNumber maxNum = new FindMaxNumber();
        /// <summary>
        /// Uc1_1
        /// </summary>
        [Test]
        public void GivenMaxfirstname_whenanalysed_shouldReturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            int result = maxNum.FindMaxInterger(30, 2, 5);
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual(30, result);
        }
        /// <summary>
        /// Uc1_2
        /// </summary>
        [Test]
        public void GivenMaxSecondname_whenanalysed_shouldReturnSecondmax()
        {
          

            int result = maxNum.FindMaxInterger(2, 30, 5);
            
            Assert.AreEqual(30, result);
        }
        /// <summary>
        /// Uc1_3
        /// </summary>
        [Test]
        public void GivenMaxThirdname_whenanalysed_shouldReturnThirdmax()
        {


            int result = maxNum.FindMaxInterger(2, 5, 30);

            Assert.AreEqual(30, result);
        }



    }
}