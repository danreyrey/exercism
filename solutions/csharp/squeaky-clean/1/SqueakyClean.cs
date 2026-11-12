using System;
using System.Linq;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string cleanedIdentifier = identifier.Replace(' ', '_');
        
        string builderCTRL = "";
        foreach (char c in cleanedIdentifier)
        {
            if (char.IsControl(c)) builderCTRL += "CTRL";
            builderCTRL += c;
        }    
        cleanedIdentifier = builderCTRL;

        string builderKebabCase = "";
        bool isKebabCase = false;
        foreach (char c in cleanedIdentifier)
        {
            if (c == '-')
            {
                isKebabCase = true;
                continue;
            }
            else
            {
                if (isKebabCase)
                {
                    builderKebabCase += char.ToUpper(c);
                    isKebabCase = false;
                }
                else
                {
                    builderKebabCase += c;
                }
            }
        }    
        cleanedIdentifier = builderKebabCase;
        
        string builderNoLetters = "";
        foreach (char c in cleanedIdentifier)
        {
            if (char.IsLetter(c) || c == '_') builderNoLetters += c;
            continue;
        }    
        cleanedIdentifier = builderNoLetters;

        string builderNoGreekLowerCaseLetters = "";
        foreach (char c in cleanedIdentifier)
        {
            if (c >= '\u0370' && c <= '\u03FF' && char.IsLower(c)) continue;
            builderNoGreekLowerCaseLetters += c;
        }    
        cleanedIdentifier = builderNoGreekLowerCaseLetters;

        return cleanedIdentifier;
        
    }
}
