namespace LeetLib;

public class Pascal_sTriangleV3 : Pascal_sTriangleBase
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

        GetRow(numRows - 1);

        int[] GetRow(int row)
        {
            var newRow = new int[row + 1];

            if (row != 0)
            {
                var prevRow = GetRow(row - 1);
                for (var i = 0; i <= row; i++)
                {
                    if (i == 0 || i == row)
                        newRow[i] = 1;
                    else
                        newRow[i] = prevRow[i - 1] + prevRow[i];
                }
            }
            else
            {
                newRow[0] = 1;
            }

            dict[row] = newRow;
            return newRow;
        }
        
        return dict.Values.Select(IList<int> (x) => x).ToList();
    }

    public override string Name => "V3";
}