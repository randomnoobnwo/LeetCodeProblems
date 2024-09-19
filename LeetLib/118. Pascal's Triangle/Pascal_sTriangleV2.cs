namespace LeetLib;

public class Pascal_sTriangleV2 : Pascal_sTriangleBase
{
    public override IList<IList<int>> Pascal_sTriangle(int numRows)
    {
        
        /*
         
         for each row in numRows
            create a list of row length and place it into dict where key is row number
            for i = 0 to row length
                if i == 0 or i == row length
                    set list[i] = 1
                else
                    set list[i] = rows[row - 1][i-1] + rows[row-1][i]
                    
         
         */

        var dict = new Dictionary<int, int[]>();

        if (numRows == 0) return new List<IList<int>>();
        dict[0] = new[] { 1 };

        for (var row = 1; row < numRows; row++)
        {
            var newRow = new int[row + 1];
            var prevRow = dict[row - 1];
            for (var i = 0; i <= row; i++)
            {
                if (i == 0 || i == row)
                    newRow[i] = 1;
                else if (row > 1)
                    newRow[i] = prevRow[i - 1] + prevRow[i];
            }
            
            dict[row] = newRow;
        }

        return dict.Values.Select(IList<int> (x) => x).ToList();
    }

    public override string Name => "V2";
}