using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((limit - diff) > ((-9) - diff))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) > limit) || (19.0 <= (double)diff))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (59 + diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff * 3) >= diff)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.08 * 18.0) != (double)entry) || (matches < (entry - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
