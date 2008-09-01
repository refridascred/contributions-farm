using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item <= 19.0)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
