using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Contracts.Files
{
    public class FileCreateModel
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Контент.
        /// </summary>
        public byte[] Content { get; set; } = null!;
        /// <summary>
        /// Тип контента.
        /// </summary>
        public string? ContentType { get; set; }
    }
}
