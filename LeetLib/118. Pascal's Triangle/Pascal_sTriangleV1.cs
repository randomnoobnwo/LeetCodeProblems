namespace LeetLib;

public class Pascal_sTriangleV1 : Pascal_sTriangleBase
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

        for (var row = 0; row < numRows; row++)
        {
            dict[row] = new int[row + 1];
            for (var i = 0; i <= row; i++)
            {
                if (i == 0 || i == row)
                    dict[row][i] = 1;
                else if (row > 1)
                    dict[row][i] = dict[row - 1][i - 1] + dict[row - 1][i];
            }
        }

        return dict.Values.Select(IList<int> (x) => x).ToList();
    }

    public override string Name => "V1";
}