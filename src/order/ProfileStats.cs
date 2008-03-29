using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route record series from a seed.</summary>
        public static long SeriesRouteRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long MeasureCacheCommandHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((8.3 / 4.0) > (double)entry)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel layout sample.</summary>
        public static long SeekChannelLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long target2)
        {
            if ((double)target2 < (1.43 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((target2 & 3) > (target >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((target + target2) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
