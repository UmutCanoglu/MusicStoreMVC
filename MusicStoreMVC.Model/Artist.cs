using MusicStoreMVC.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.Model
{
    public class Artist : BaseEntity
    {
        public string FullName { get; set; }
        public byte Rating { get; set; }

        public virtual List<Album> Albums { get; set; }

    }
}
