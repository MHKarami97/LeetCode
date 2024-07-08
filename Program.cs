using LeetCode.Problems;

Console.WriteLine("Start");

const int ProblemId = 242;

switch (ProblemId)
{
    case 242:
        var p242 = new P242().IsAnagram("anagram", "nagaram");
        break;

    default:
        Console.WriteLine("Not valid problem id");
}