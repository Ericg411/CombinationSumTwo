namespace CombinationSumTwo.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;
        var result = _test.CombinationSum2(candidates, target);
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> list1 = new List<int>() { 1, 1, 6 };
        IList<int> list2 = new List<int>() { 1, 2, 5 };
        IList<int> list3 = new List<int>() { 1, 7 };
        IList<int> list4 = new List<int>() { 2, 6 };
        answer.Add(list1);
        answer.Add(list2);
        answer.Add(list3);
        answer.Add(list4);

        bool isEqual = true;

        for (int i = 0; i < answer.Count; i++) 
        {
            if (!answer[i].SequenceEqual(result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    } 
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] candidates = { 2, 5, 2, 1, 2 };
        int target = 5;
        var result = _test.CombinationSum2(candidates, target);
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> list1 = new List<int>() { 1, 2, 2 };
        IList<int> list2 = new List<int>() { 5 };
        answer.Add(list1);
        answer.Add(list2);

        bool isEqual = true;

        for (int i = 0; i < answer.Count; i++) 
        {
            if (!answer[i].SequenceEqual(result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    }
}