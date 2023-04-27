using System.Threading.Tasks;

namespace App2_test_template_2.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
