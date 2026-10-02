using System.Collections.Generic;
using System.Linq;

public static class KillerSudokuHelper
{
    public static IEnumerable<int[]> Combinations(int sum, int size, int[] exclude)
    {
        IEnumerable<int[]> combinations = Enumerable.Empty<int[]>();
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> filteredNumbers = numbers.Except(exclude).ToList();
        
        if (size == 1) return combinations = combinations.Append(new int[] { sum });
        else if (size == 9)
        {
            combinations = combinations.Append(numbers.ToArray());
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
                        if (selected.Contains(next)) return null;
                        if (next <= selected.Last()) return null;
                        return new List<int>(selected) { next };
                    }
                ).Where(x => x != null);
            }
            
            List<List<int>?> results = query.Where(x => x?.Sum() == sum).ToList();
    
            foreach (var result in results)
            {
                if (result != null) combinations = combinations.Append(result.ToArray());
            }
            return combinations;   
        }
    }
}
