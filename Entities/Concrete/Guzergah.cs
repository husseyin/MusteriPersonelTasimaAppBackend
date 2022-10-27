using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Guzergah : IEntity
    {
        public int GuzergahId { get; set; }
        public string GuzergahAdi { get; set; }
        public string GuzergahLoc { get; set; }
        public string Firma { get; set; }
    }
}
