using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double mean = scale - (offset / 5.0);
            if (mean > scale)
            {
                mean = mean + mean;
            }
            return mean - (offset - scale);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double bias = (6.8 + scale) + (double)307;
            if (bias >= scale)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 8.64) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + (mark - (long)i);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
