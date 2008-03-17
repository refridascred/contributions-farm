using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = 5.28;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (gain * 18.0)) + (double)(long)i) + bias) - span;
            }
            return gain - (double)600;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long seed)
        {
            long bound = origin + seed;
            if ((double)seed > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((8.75 * 12.0) > (4.0 + 19.0))
                {
                    return 0;
                }
                else
                {
                    if ((579 - bound) >= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) >= (329 % 97))
                        {
                            return 3;
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
}
