public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)  // ← изменено здесь
    {
        var dict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var sorted = string.Concat(s.OrderBy(c => c));

            if (!dict.ContainsKey(sorted))
            {
                dict[sorted] = new List<string>();
            }
            dict[sorted].Add(s);
        }

        var res = dict.Values.ToList();
        return res;
    }
}