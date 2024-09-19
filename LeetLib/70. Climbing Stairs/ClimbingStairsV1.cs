namespace LeetLib;

public class ClimbingStairsV1 : ClimbingStairsBase
{
    public override int ClimbingStairs(int n)
    {
/*

Input: n = 3
   Output: 3
   Explanation: There are three ways to climb to the top.
   1. 1 step + 1 step + 1 step
   2. 1 step + 2 steps
   3. 2 steps + 1 step

n = 3

Decision:
find number of way to reach 3 by stepping by 1 or 2

take 1 or 2 steps
 if steps left is 0 return 1 - exactly reached the top

 if steps left is less than 0 return 0 - overstepped so not a case

    if steps left is greater than 0
        take 1 step
        take 2 steps
        return sum of both

    sum of 1 and 2 steps would give us the total number of ways to reach the top for both cases
 */
        var dict = new Dictionary<(int, int), int>();
        return Climb(1, n) + Climb(2, n);

        int Climb(int takeSteps, int stepsLeft)
        {
            if (dict.ContainsKey((takeSteps, stepsLeft)))
                return dict[(takeSteps, stepsLeft)];

            var steps = stepsLeft - takeSteps;

            if (steps == 0)
            {
                dict[(takeSteps, stepsLeft)] = 1;
                return 1;
            }

            if (steps < 0)
            {
                dict[(takeSteps, stepsLeft)] = 0;
                return 0;
            }

            var result = Climb(1, steps) + Climb(2, steps);
            dict[(takeSteps, stepsLeft)] = result;

            return result;
        }
    }

    public override string Name => "V1";
}