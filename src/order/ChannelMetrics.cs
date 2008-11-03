using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) != (long)readings.Length) && (((cell / 9) >= seen) || ((seen / 3) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches profile pair into a bucket.</summary>
        public static long SortBatchesProfile(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (!(bound <= cur))
            {
                return 1;
            }
            else
            {
                if (!((bound + 77) <= (bound - 650)))
                {
                    return 6;
                }
                else
                {
                    if (((820 + 517) > cur) || ((bound / 7) > bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.06 * 5.5) <= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
