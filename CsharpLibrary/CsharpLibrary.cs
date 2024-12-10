using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;

namespace OfficeSamuraiREFramework
{
    public static class ProjectLibrary
    {
        //Konwersja liczby na zapis słowny (dla języka angielskiego):
        public static string ConvertNumberToWords(int number)
        {
            if (number == 0) return "zero";
        
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        
            if (number < 20) return units[number];
            if (number < 100) return tens[number / 10] + (number % 10 > 0 ? " " + units[number % 10] : "");
        
            // ... można rozszerzyć dla większych liczb
            return number.ToString(); // Jeśli liczba jest poza zakresem, zwróć ją jako ciąg
        }
        //Ucinanie tekstu do określonej długości z opcjonalnymi "..." na końcu
        public static string TruncateString(string input, int maxLength, bool useEllipsis = true)
        {
            if (string.IsNullOrEmpty(input) || maxLength <= 0) return string.Empty;
            if (input.Length <= maxLength) return input;
        
            string result = input.Substring(0, maxLength);
            return useEllipsis ? result + "..." : result;
        }
    }
}