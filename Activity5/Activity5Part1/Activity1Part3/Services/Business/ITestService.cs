using Activity1Part3.Utility;
using Unity;

namespace Activity1Part3.Services.Business
{
    public interface ITestService
    {
        void Initialize(ILogger logger);
        void TestLogger();
    }
}
