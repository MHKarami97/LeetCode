using LeetCode;
using LeetCode.Problems;

Console.WriteLine("Start");

try
{
    const int problemId = 53;
    IProgram program;


    switch (problemId)
    {
        case 242:
            program = new P242();
            program.Run();
            Benchmarker.Do<P242>();
            break;

        case 53:
            program = new P53();
            program.Run();
            Benchmarker.Do<P53>();
            break;

        default:
            throw new Exception("Not valid problem id");
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}