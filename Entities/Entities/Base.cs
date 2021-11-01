using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Base : Notify
    {
        /// <summary>
        /// Propriedade Id 
        /// </summary>
        [Display(Name = "Código")]
        public int Id { get; set; }


        /// <summary>
        /// Propriedade Nome
        /// </summary>
        [Display(Name = "Nome")]
        public string Name { get; set; }


    }
}
