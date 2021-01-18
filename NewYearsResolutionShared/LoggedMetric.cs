using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsResolutionShared
{
    public class LoggedMetric
    {
        public int Id { get; set; }

        public int ResolutionId { get; set; }

        public DateTime Date { get; set; }

        public int Value { get; set; }

    }
}
