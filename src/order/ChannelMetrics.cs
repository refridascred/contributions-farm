using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long step)
        {
            long carry = 223;
            foreach (long cell in samples)
            {
                carry = (((carry * 4) + (755 << 2)) - cell) - step;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2861;
        public const double DefaultDepth = 87.92;
        public const long MaxRatio = 7141;
    }
}
