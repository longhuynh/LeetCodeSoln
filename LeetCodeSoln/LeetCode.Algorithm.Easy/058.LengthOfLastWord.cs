/**
 * https://leetcode.com/problems/length-of-last-word/
 * 
 * Tags: String
 */

public class LastWordLength
{
    /*
     Traverse backwards
     Use count to remember length of word
     Start counting from non-space char
     Return when next space is met and length is not zero
     */

    public int LengthOfLastWord(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        var length = s.Length;
        var count = 0;

        for (var i = length - 1; i >= 0; i--)
        {
            if (s[i] != ' ') count++;
            if (s[i] == ' ' && count != 0) return count;
        }
        return count;
    }

    // trim and check from back
    public static int LengthOfLastWord2(string s)
    {
        s = s.Trim(); // remove front and trailing spaces
        var space = ' ';
        if (s.IndexOf(space) == -1) return s.Length; // dont have a space
        var length = s.Length;
        for (var i = length - 1; i >= 0; i--)
        {
            // traverse backwards
            if (s[i] == ' ' && i != length - 1)
            {
                // is space and not last one
                return length - 1 - i;
            }
        }
        return 0;
    }
}