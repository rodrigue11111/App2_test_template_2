using System.Threading.Tasks;

namespace App2_test_template_2.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
