public class Solution 
{
    public int RomanToInt(string s) 
    {
        int i = 0;
        int value = 0;
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                value = value + 1;
            }
            else if (s[i] == 'V')
            {
                value = value + 5;
            }
            else if (s[i] == 'X')
            {
                value = value + 10;
            }
            else if (s[i] == 'L')
            {
                value = value + 50;
            }
            else if (s[i] == 'C')
            {
                value = value + 100;
            }
            else if (s[i] == 'D')
            {
                value = value + 500;
            }
            else if (s[i] == 'M')
            {
                value = value + 1000;
            }
        }
        for (i = 0; i < s.Length - 1; i++)
        {
            if (s.Substring(i, 2) == "IV" || s.Substring(i, 2) == "IX")
            {
                value = value - 2;
            }
            else if (s.Substring(i, 2) == "XL" || s.Substring(i, 2) == "XC")
            {
                value = value - 20;
            }
            else if (s.Substring(i, 2) == "CD" || s.Substring(i, 2) == "CM")
            {
                value = value - 200;
            }
        }
        return value;    
    }
}