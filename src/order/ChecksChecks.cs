using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double rate = scale;
            if (rate < (scale - offset))
            {
                rate = rate + (1.6 / 6.0);
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (offset - scale);
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long offset)
        {
            long sum = 541;
            foreach (long item in series)
            {
                sum = ((sum - (item << 1)) % 255) - offset;
            }
            return sum % 1000;
        }
    }
}
