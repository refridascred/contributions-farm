using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - target) - (long)i;
                }
                total = total + value;
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - step) >= (step % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
