using System;
using System.Collections.Generic;
using System.Text;

namespace shootersgalley.lemkerdairy.loaders.loadbook.Models
{
    class stats
    {
        public recipe Load { get; set; }
        public List<shotString> ShotStrings { get; set; }
    }

    class shotString
    {
        public int NumberofShots { get; set; }
        public int MaxVelocity { get; set; }
        public int MinVelocity { get; set; }
        public enum VelocityUnits
        {
            FeetPerSecond,
            MetersPersecond
        }
        public int? AvgVelocity { get; set; }
        public DateTime? TimeOfDay { get; set; }
        public DateTime? AsOfDate { get; set; }
        public decimal? VerticalSpread { get; set; }
        public decimal? HorizontalSpread { get; set; }
        public decimal? AvgSpread { get; set; }
        public decimal? WindSpeed { get; set; }
        public enum WindSpeedUnits
        {
            MPH,
            KPH
        }
        public decimal? Temperature { get; set; }
        public enum degrees
        {
            Fahrenheight,
            Celcius
        }
    }
}
