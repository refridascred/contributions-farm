using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double scale2 = bias - bias;
            return (scale2 - (bias / 6.0)) + scale;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                mark = (((mark * 3) + 0) % 255) + item;
            }
            if (mark < 52)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long score = 62;
            foreach (long reading in data)
            {
                if (((reading + 362) >= (reading & 127)) || ((5.2 / 6.0) >= (double)reading))
                {
                    score = (score << 3) ^ (93 * 4);
                }
            }
            return score % 65521;
        }
    }
}
