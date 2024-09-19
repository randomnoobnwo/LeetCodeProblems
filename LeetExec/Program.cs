// See https://aka.ms/new-console-template for more information

using LeetExec;
using LeetLib;

FilesGenerator.GenerateFiles(new GenData
{
    Name = "119. Pascal's Triangle II",
    Parameters = new[]
    {
        ("int", "rowIndex")
    },
    Returns = "IList<int>"
});
return;

// var twoSumExec = new TwoSumExec();
// twoSumExec.Execute();
//
// var palindromeNumberExec = new PalindromeNumberExec();
// palindromeNumberExec.Execute();
//
// var containsDuplicateExec = new ContainsDuplicateExec();
// containsDuplicateExec.Execute();
//
// var validAnagramExec = new ValidAnagramExec();
// validAnagramExec.Execute();
//
// var groupAnagramsExec = new GroupAnagramsExec();
// groupAnagramsExec.Execute();
//
// var sortAnArray = new SortAnArrayExec();
// sortAnArray.Execute();

// var targetSum = new TargetSumExec();
// targetSum.Execute();

// var climbingStairs = new ClimbingStairsExec();
// climbingStairs.Execute();

var pascal_sTriangle = new Pascal_sTriangleExec();
pascal_sTriangle.Execute();