public class Solution
{
    public string Encode(IList<string> strs)
    {
        string res = "";
        foreach (var item in strs)
        {
            res += item.Length + "#" + item;
        }

        return res;
    }

    public List<string> Decode(string s)
    {
        List<string> list = new List<string>();

        int i = 0;

        for (; i < s.Length;)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }

            //получаем число
            int len = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            j = i + len;

            list.Add(s.Substring(i, len));

            i = j;
        }

        return list;
    }
}
