using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seen) >= 85)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 * 5) > (datum / 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long limit)
        {
            long delta = target ^ limit;
            if (target >= (579 & 1))
            {
                return 8;
            }
            else
            {
                if (limit >= (target & 15))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + limit) == (delta / 2)) && ((0 - limit) != ((-166) + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
