using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using LeetCode.Problems;

namespace LeetCode;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net80, baseline: true)]
[RPlotExporter]
public class BenchmarkCode
{
    private P242 _problem242;
    private P53 _problem53;

    [GlobalSetup]
    public void Setup()
    {
        _problem242 = new P242();
        _problem53 = new P53();
    }

    [Benchmark]
    public bool IsAnagram() => _problem242.IsAnagram("anagram", "nagaram");

    [Benchmark]
    public int MaxSubArray() => _problem53.MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
}