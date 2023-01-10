using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchMark.NET;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser()]
public class Strings
{
    [Benchmark]
    public void BuildStringsWithConcatenation()
    {
        var output = String.Empty;
        for (var i = 0; i < 100; i++)
        {
            output += "test";
        }
    }

    [Benchmark]
    public void BuildStringsWithStringBuilder()
    {
        var output = String.Empty;

        var builder = new StringBuilder();
        for (var i = 0; i < 100; i++)
        {
            builder.Append("test");
        }

        output = builder.ToString();
    }
}