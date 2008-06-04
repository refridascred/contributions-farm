using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command cache value from a seed.</summary>
        public static long DeriveCommandCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - seed) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = (double)(0 / 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 7.6) + (double)(long)i) - scale;
            }
            return mean - (span * 16.0);
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double gain = (double)76;
            if (gain <= 6.68)
            {
                gain = (gain - floor) - rate;
            }
            return gain - floor;
        }
    }
}
