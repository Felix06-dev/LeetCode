public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        string baseString = strs[0];
        
        string prefix = "";
        
        for(int i = 0; i < baseString.Length; i++)
        {
            char currentCharacter = baseString[i];
            
            foreach(string word in strs)
            {
                if (i >= word.Length || word[i] != currentCharacter)
                {
                    return prefix;
                }  
            }
            
            prefix += currentCharacter;
        
        }
        
        return prefix;
    }
}