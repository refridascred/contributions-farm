using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(datum >= seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 4625;
        public const double LimitCommand = 44.45;
        public const long MaxWidth = 9965;
        public const double CacheCommand = 23.21;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Ready,
            Stale,
            Pending,
        }
    }
}
