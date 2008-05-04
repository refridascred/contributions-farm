using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstWidth = 6679;
        public const double WindowCount = 35.21;
        public const long CacheNotes = 3493;

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            long diff = bound - limit;
            if (diff <= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((double)diff == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 5.26) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
