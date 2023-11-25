namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var boolIsNumber = true;
            Assert.True(boolIsNumber);
        }

        [Fact]
        public void test2()
        {
            var testtest = new test_automationtest.Functions.Functions();
            var result = testtest.test1(5, true);

               
            






            Assert.Equal(25, result);
        }
    }
}