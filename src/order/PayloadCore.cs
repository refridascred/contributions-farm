using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((score + floor) <= score)
                {
                    score = score - (score - floor);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long floor)
        {
            long cur = seed + floor;
            if (floor < cur)
            {
                return 5;
            }
            else
            {
                if ((cur + floor) > (floor + cur))
                {
                    return 0;
                }
                else
                {
                    if ((floor > (cur * 4)) && ((double)cur >= (7.0 * 7.1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6 >> 3) < seed) && ((530 / 4) > cur))
                        {
                            return 7;
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
