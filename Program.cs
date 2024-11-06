using BenchmarkDotNet.Running;
using LeetCode;
using LeetCode.Problems;

Console.WriteLine("Start");

try
{
    const int ProblemId = 53;
    const bool NeedBenchmark = false;


    switch (ProblemId)
    {
        case 242:
            var p242 = new P242().IsAnagram("anagram", "nagaram");
            break;

        case 53:
            var p53 = new P53().MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
            break;

        default:
            Console.WriteLine("Not valid problem id");
            break;
    }

    if (NeedBenchmark)
    {
        BenchmarkRunner.Run<BenchmarkCode>();
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}