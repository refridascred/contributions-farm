using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double ratio = scale;
            return (ratio - scale) + bias;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
