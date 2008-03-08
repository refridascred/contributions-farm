using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double rate2 = 7.2;
            if (rate2 < (span - span))
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 - (span + span);
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
