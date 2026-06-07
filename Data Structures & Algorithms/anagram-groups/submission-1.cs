public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs) {
                
                    
        var res = new Dictionary<string, List<string>>();
        foreach (var item in strs)
        {
            int[] count = new int[26];

            foreach (var c in item)
            {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }

            res[key].Add(item);

        }
        return res.Values.ToList<List<string>>();
                    }

}