using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (bias - span))
            {
                bias2 = bias2 + (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (double)(-1)) + (double)(long)i;
            }
            return bias2 - (3.53 + bias2);
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
