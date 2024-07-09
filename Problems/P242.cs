using System.Collections;

namespace LeetCode.Problems;

/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.



Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false


Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.


Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/
public class P242
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var hashtable = new Hashtable(s.Length);
        var hashtable1 = new Hashtable(s.Length);

        for (var item = 0; item < s.Length; item++)
        {
            if (!hashtable.ContainsKey(s[item]))
            {
                hashtable.Add(s[item], 1);
            }
            else
            {
                hashtable[s[item]] = (int)hashtable[s[item]] + 1;
            }

            if (!hashtable1.ContainsKey(t[item]))
            {
                hashtable1.Add(t[item], 1);
            }
            else
            {
                hashtable1[t[item]] = (int)hashtable1[t[item]] + 1;
            }
        }

        foreach (DictionaryEntry item in hashtable)
        {
            if (!item.Value.Equals(hashtable1[item.Key]))
            {
                return false;
            }
        }

        return true;
    }
}