using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up checks tools samples.</summary>
        public static long PairChecksToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            if ((target + 153) >= (5 + offset))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) >= (target * 4))
                {
                    return 2;
                }
                else
                {
                    if ((8.33 + 7.65) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset != (0.06 + 2.99)) || ((42 + offset) < (offset + offset)))
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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches > floor)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
