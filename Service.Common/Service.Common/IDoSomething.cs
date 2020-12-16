using System.Threading.Tasks;

namespace Service.Common
{
    public interface IDoSomething
    {
        Task PrintMessage(int times);
    }
}
