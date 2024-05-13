namespace UnitTest
{
    [ClassTest]
    public class UnitTest
    {
        [MethodTest]
        public void TestCalculateCal()
        {
                int[] value = {1, 2, 3, 4, 5};
                int result = calculte_num_of_calorie(value);

                // Assert
                Assert.AreEqual(15, result); // Expected cal is 1 + 2 + 3 + 4 + 5 = 15
        }
            public int calculte_num_of_calorie(int[] Num)
            {
                int cal = 0;
                foreach (int num in Num)
                {
                    cal += Num[num];
                }
                return cal;            
            }
    }
}
