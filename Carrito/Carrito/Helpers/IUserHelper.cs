using Carrito.Data.Entities;
using Carrito.Models;
using Microsoft.AspNetCore.Identity;

namespace Carrito.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        //SignInResult es el metodo que avisa si pudo o no loguearse y si no pudo dice el porque
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }

}
