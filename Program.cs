using LeetCode.Problems;

Console.WriteLine("Start");

const int ProblemId = 53;

switch (ProblemId)
{
    case 242:
        var p242 = new P242().IsAnagram("anagram", "nagaram");
        break;

    case 53:
        var p53 = new P53().MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        break;

    default:
        Console.WriteLine("Not valid problem id");
}