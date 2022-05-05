using System.Threading.Tasks;
using MultiboardClient.Utils;

namespace MultiboardClient.ViewModels
{
    public class AuthenticationWindowViewModel
    {
        public async Task<bool> Login(string username, string password)
        {
            await Task.Delay(200);

            if (username == Texts.OFFLINE_TEST_USERNAME && password == Texts.OFFLINE_TEST_PASSWORD)
                return true;

            return false;
        }
    }
}
