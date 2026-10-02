using System.Collections.Generic;
using System.Linq;

public static class KillerSudokuHelper
{
    public static IEnumerable<int[]> Combinations(int sum, int size, int[] exclude)
    {
        IEnumerable<int[]> combinations = [];
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> filteredNumbers = [.. numbers.Except(exclude)];
        
        if (size == 1) return combinations = combinations.Append([sum]);
        else if (size == 9)
        {
            combinations = combinations.Append([.. numbers]);
            return combinations;
        }
        else
        {
            IEnumerable<List<int>?> query = filteredNumbers.Select(z => new List<int> { z });

            for (int i = 1; i < size; i++)
            {
                query = query.SelectMany(
                    selected => filteredNumbers,
                    (selected, next) => 
                    {
                        if (selected is not null)
                        {
                            if (selected.Contains(next)) return null;
                            if (next <= selected.Last()) return null;
                            return [.. selected, next];
                        }
                        return new List<int>() {  };
                    }
                ).Where(x => x != null);
            }

        List<List<int>?> results = [.. query.Where(x => x?.Sum() == sum)];
    
        foreach (var result in results)
        {
            if (result != null) combinations = combinations.Append([.. result]);
        }
        
        return combinations;                
        }
    }
}
