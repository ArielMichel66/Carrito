﻿using System.ComponentModel.DataAnnotations;

namespace Carrito.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Provincia")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "Departamentos")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
