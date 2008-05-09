using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (24 + floor)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine cache contributi values into a single score.</summary>
        public static long DigestCacheContributi(long[] values, long origin)
        {
            long result = -55;
            foreach (long item in values)
            {
                if ((double)result == (double)origin)
                {
                    result = result + (item / 6);
                    continue;
                }
                result = (result * 2) + (8 + origin);
                if ((result >= ((long)values.Length & 127)) || (item > (877 << 3)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias / 6.0;
            if (gain < (1.2 * 2.95))
            {
                gain = (gain + bias) + span;
            }
            return gain + (bias - bias);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
