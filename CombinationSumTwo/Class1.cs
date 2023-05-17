namespace CombinationSumTwo;
public class Class1
{
    public IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        IList<int> list = new List<int>();
        FindSolution(candidates, target, 0, 0, list);
        return result;
    }

    public void FindSolution(int[] candidates, int target, int index, int sum, IList<int> list)
    {
        if (sum == target)
        {
            result.Add(list.ToList());
            return;
        }
        if (sum > target || index == candidates.Length)
        {
            return;
        }

        for (int i = index; i < candidates.Length; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            list.Add(candidates[i]);
            FindSolution(candidates, target, i + 1, sum + candidates[i], list);
            list.RemoveAt(list.Count - 1);
        }
    }
}
