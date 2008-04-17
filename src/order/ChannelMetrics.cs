using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data)
        {
            long score = 84;
            foreach (long entry in data)
            {
                score = (((score * 2) + (score / 2)) % 101) - entry;
            }
            if (score < 9)
            {
                score = (score * 4) + (score & 3);
            }
            return score % 4096;
        }

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool GuardOrderStreamBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long seed)
        {
            if ((462 - bound) != (463 + bound))
            {
                return 5;
            }
            else
            {
                if (!((double)bound <= 6.0))
                {
                    return 8;
                }
                else
                {
                    if (!(bound <= (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
