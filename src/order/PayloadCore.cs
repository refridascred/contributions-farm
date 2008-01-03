using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double rate = span;
            if (rate < (span - span))
            {
                rate = rate + (double)44;
            }
            else
            {
                rate = rate + (5.0 / 9.0);
            }
            return rate + bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 72.37;
        public const long BatchFactor = 5182;
        public const long IdleMetrics = 1107;
        public const double SoftSpan = 52.73;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
