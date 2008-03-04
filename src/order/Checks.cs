using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (17 ^ (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((770 >> 5) >= (matches << 1)))
                {
                    matches = ((matches + 3) ^ reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double load = scale;
            if (load <= scale)
            {
                load = (load - (load + load)) - span;
            }
            return load + 6.64;
        }
    }
}
