using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class WorkingHour : IEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PersonelId { get; set; }
        public int ShiftId { get; set; }
        public int Hours { get; set; }
    }
}
