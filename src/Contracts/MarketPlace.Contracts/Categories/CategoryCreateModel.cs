using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Contracts.Categories
{
    public class CategoryCreateModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
    }
}
