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
        public int JobId { get; set; }
        public int Hours { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int? DowntimeId { get; set; }
    }
}
