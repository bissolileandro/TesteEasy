public class Solution {
    public bool DetectCapitalUse(string word) {
        if (string.IsNullOrEmpty(word)) 
            return false;
        if (word == word.ToUpper()) 
            return true;
        if (word == word.ToLower()) 
            return true;
        if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower()) 
            return true;
        
        return false;
    }
}