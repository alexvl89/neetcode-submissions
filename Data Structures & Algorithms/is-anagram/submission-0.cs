public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        //проверим на длину
        if (s.Length != t.Length)
            return false;

        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (countS.ContainsKey(s[i]))
                countS[s[i]]++;
            else
                countS.Add(s[i], 1);


            if (countT.ContainsKey(t[i]))
                countT[t[i]]++;
            else
                countT.Add(t[i], 1);
        }

        if (countS.Count != countT.Count)
            return false;

        foreach (var kvp in countS)
        {
            if (!countT.ContainsKey(kvp.Key) || countT[kvp.Key] != kvp.Value)
                return false;
        }

        return true;
    }
}