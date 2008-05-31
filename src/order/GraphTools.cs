using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long floor)
        {
            long span = target + floor;
            if ((target + (-86)) < (target ^ floor))
            {
                return 2;
            }
            else
            {
                if (!((14.0 / 4.0) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((target <= span) && ((double)target > (double)span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double rate = gain;
            if (rate > 4.98)
            {
                rate = (rate + (rate / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + 2.07;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
