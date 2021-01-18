using System;

namespace NewYearsResolutionShared
{
    public class Resolution
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Metric { get; set; }
        
        public Timeframes Timeframe { get; set; }
    }
}
