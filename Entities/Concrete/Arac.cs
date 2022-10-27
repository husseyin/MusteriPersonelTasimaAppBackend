using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Arac : IEntity
    {
        public int AracId { get; set; }
        public string AracPlaka { get; set; }
        public string Firma { get; set; }
    }
}
