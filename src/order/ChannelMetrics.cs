using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 59.57;
        public const double BurstEditor = 40.4;
        public const long BaseEditor = 2705;
        public const long BatchLevel = 5784;
        public const long LimitEditor = 2974;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long floor)
        {
            if (seed <= (0 - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    if (!(seed <= 553))
                    {
                        return 5;
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
