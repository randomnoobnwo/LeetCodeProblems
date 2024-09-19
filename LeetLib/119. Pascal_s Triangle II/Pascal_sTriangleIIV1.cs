namespace LeetLib;

public class Pascal_sTriangleIIV1 : Pascal_sTriangleIIBase
{
    public override IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0) return new List<int> { 1 };
        
        var prevRow = GetRow(rowIndex - 1);
        var newRow = new int[rowIndex + 1];
        for (var i = 0; i <= rowIndex; i++)
        {
            if (i == 0 || i == rowIndex)
                newRow[i] = 1;
            else
                newRow[i] = prevRow[i - 1] + prevRow[i];
        }

        return newRow;
    }

    public override string Name => "V1";
}