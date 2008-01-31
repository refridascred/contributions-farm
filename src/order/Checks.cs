using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Retry,
            Done,
            Queued,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long MeasureChannelContributiMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (4.7 * 19.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell > (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
