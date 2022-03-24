using Microsoft.AspNetCore.Mvc.Rendering;

namespace Carrito.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync();

        Task<IEnumerable<SelectListItem>> GetComboCountriesAsync();

        //Provincias
        Task<IEnumerable<SelectListItem>> GetComboStatesAsync(int countryId);

        //Departamento
        Task<IEnumerable<SelectListItem>> GetComboCitiesAsync(int stateId);
    }

}
