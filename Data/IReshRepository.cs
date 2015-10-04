using Data.ReshService;

namespace Data
{
    public interface IReshRepository
    {
        ReshUnit Get(int id);
    }
}