using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next stats commits value.</summary>
        public static double ProjectStatsCommits(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (gain - 7.0)) + floor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Check that every context checks entry stays within the limit.</summary>
        public static bool ValidateContextChecksLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
