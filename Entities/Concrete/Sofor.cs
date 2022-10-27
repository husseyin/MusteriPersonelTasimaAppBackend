using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sofor : IEntity
    {
        public int SoforId { get; set; }
        public string SoforAdSoyad { get; set; }
        public string SoforTc { get; set; }
        public string SoforCep { get; set; }
    }
}
