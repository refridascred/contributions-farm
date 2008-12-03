using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            if ((target << 3) < (target & 127))
            {
                return 2;
            }
            else
            {
                if ((target + target) <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 79) == ((-3) & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 + target) < (target / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((entry / 3) >= (count & 31)) || (((-5) - 303) >= offset)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
