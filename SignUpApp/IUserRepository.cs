using System.Threading.Tasks;

namespace SignUpApp
{
    public interface IUserRepository
    {
        Task<bool> Insert(User user);
    }
}
