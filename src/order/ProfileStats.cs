using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stream counter value.</summary>
        public static double AdjustStreamCounter(double gain, double bias)
        {
            double drift = 11.0;
            if (drift >= (double)3)
            {
                drift = (drift + (bias - drift)) + gain;
            }
            return drift - (bias * 19.0);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if (mark < (mark - datum))
                {
                    mark = mark + (mark & 1);
                }
                if ((mark >> 4) <= (56 % 24))
                {
                    mark = (mark << 3) ^ (mark >> 3);
                }
                else
                {
                    mark = (mark ^ datum) % 65521;
                }
                if ((mark - (-93)) < (mark >> 2))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data)
        {
            long sum = 625;
            foreach (long cell in data)
            {
                if ((cell - cell) >= sum)
                {
                    sum = sum - (cell - cell);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
