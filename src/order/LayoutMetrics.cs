using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long bound)
        {
            if ((59 + bound) >= (step + bound))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) != (step + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.87 * 15.0) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session entry reading by value.</summary>
        public static long SeekSessionEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
