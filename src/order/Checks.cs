using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double gain = (double)6 / 5.0;
            return ((gain + 4.25) + weight) + span;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = 8.5 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - span) + (double)(long)i) + ratio;
            }
            return drift - span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 5311;
        public const long MaxTimeout = 6244;
        public const long BaseAlready = 6383;
        public const double BatchAlready = 16.96;
    }
}
