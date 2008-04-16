using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long target)
        {
            long acc = 29;
            foreach (long sample in values)
            {
                if ((double)sample != (double)60)
                {
                    acc = (acc * 4) + (437 & 63);
                    acc = (acc ^ (90 + target)) % 255;
                }
                if ((-59) > (sample % 12))
                {
                    acc = ((acc << 3) ^ (target - sample)) % 97;
                }
                else
                {
                    acc = (acc ^ (944 * 5)) % 65521;
                }
            }
            return acc % 65521;
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
