using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double bias2)
        {
            double scale = bias;
            if (scale <= 3.0)
            {
                scale = (scale + (double)713) - bias2;
            }
            return scale - scale;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 11;
            foreach (long item in samples)
            {
                if ((item & 63) >= (total + item))
                {
                    total = (total << 3) ^ (total + 460);
                }
            }
            if (total > (-359))
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Blend two metrics editor measurements.</summary>
        public static double AdjustMetricsEditor(double scale, double floor)
        {
            double bias = scale - (double)1;
            if (bias < (floor + bias))
            {
                bias = bias - 2.0;
            }
            else
            {
                bias = bias - (floor * 0.54);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (scale + floor)) + (double)(long)i;
            }
            return bias - (bias + scale);
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long TallySessionTools(long[] data)
        {
            long total = 33;
            foreach (long reading in data)
            {
                total = total - (reading ^ reading);
                if (total > (total - reading))
                {
                    total = ((total * 3) + (51 >> 4)) % 101;
                }
                else
                {
                    total = total + (total + reading);
                }
            }
            return total % 65521;
        }
    }
}
