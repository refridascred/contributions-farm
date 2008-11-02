using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 >= scale)
            {
                scale2 = scale2 + 5.1;
            }
            return scale2 + (bias - scale2);
        }

        /// <summary>Project the next support filter value.</summary>
        public static double ScaleSupportFilter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > 4.8)
            {
                gain2 = (gain2 + gain2) + span;
            }
            return gain2 + gain2;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((0.2 / 6.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((6 - origin) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((origin < lane) && (lane < (origin >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18.0 * 7.35) == (double)origin)
                        {
                            return 0;
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
}
