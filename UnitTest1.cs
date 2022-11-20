namespace FindMaxNum
{
    public class Tests
    {
        FindMaxNumber maxNum = new FindMaxNumber();

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
        public void GivenMaxSecondname_whenanalysed_shouldReturnSecondmax()
        {
          

            int result = maxNum.FindMaxInterger(2, 30, 5);
            
            Assert.AreEqual(30, result);
        }




    }
}