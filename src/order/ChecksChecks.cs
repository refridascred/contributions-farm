using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double SmoothEntryCounter(double rate, double span)
        {
            double rate2 = 9.3;
            if (rate2 >= (span / 4.0))
            {
                rate2 = (rate2 - span) - rate;
            }
            else
            {
                rate2 = rate2 + (span * 4.26);
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Done,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
