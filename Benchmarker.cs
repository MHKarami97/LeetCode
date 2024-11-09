using System.Diagnostics;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace LeetCode;

public static class Benchmarker
{
    const bool NeedBenchmark = true;

    private static readonly IConfig Config = ManualConfig
        .Create(DefaultConfig.Instance)
        .AddExporter(HtmlExporter.Default)
        .AddDiagnoser(MemoryDiagnoser.Default)
        .AddDiagnoser(ThreadingDiagnoser.Default)
        .AddDiagnoser(ExceptionDiagnoser.Default)
        .AddJob(Job.Default
            .WithRuntime(CoreRuntime.Core80)
            .WithPlatform(Platform.X64)
            .WithJit(Jit.Default)
            .WithGcServer(true)
        );

    public static void Do<T>()
    {
        if (NeedBenchmark)
        {
            BenchmarkRunner.Run<T>(Config);
            ShowResult(typeof(T).Name);
        }
    }

    private static void ShowResult(string name)
    {
        try
        {
            var reportFinalPath = Path.Combine(Directory.GetCurrentDirectory(), $@"BenchmarkDotNet.Artifacts\results\LeetCode.Problems.{name}-report.html");

            if (File.Exists(reportFinalPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = reportFinalPath,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("Report not found.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Report can not open.");
        }
    }
}