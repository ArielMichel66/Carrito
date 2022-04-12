using Carrito.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Carrito.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync();

        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync(IEnumerable<Category> filter);

        Task<IEnumerable<SelectListItem>> GetComboCountriesAsync();

        //Provincias
        Task<IEnumerable<SelectListItem>> GetComboStatesAsync(int countryId);

        //Departamento
        Task<IEnumerable<SelectListItem>> GetComboCitiesAsync(int stateId);
    }

}
