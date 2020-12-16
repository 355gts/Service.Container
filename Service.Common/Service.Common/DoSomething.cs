using System;
using System.Threading.Tasks;

namespace Service.Common
{
    public class DoSomething : IDoSomething
    {
        public async Task PrintMessage(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"This is the {i} printed message.");
                await Task.Delay(5000);
            }
        }
    }
}
