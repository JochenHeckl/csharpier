using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class CoalesceExpressionTests : BaseTest
    {
        [Test]
        public void BasicCoalesceExpression()
        {
            this.RunTest("CoalesceExpression", "BasicCoalesceExpression");
        }
    }
}