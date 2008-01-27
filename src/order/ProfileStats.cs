using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (double)9 - bias;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (bias / 6.0)) + (double)(long)i;
            }
            return ratio + (bias + 9.09);
        }

        /// <summary>Adjust a tools githubfarm reading.</summary>
        public static double SmoothToolsGithubfarm(double weight, double offset)
        {
            double mean = (double)(585 ^ 213);
            if (mean >= (double)(-970))
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean + (weight - mean);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data)
        {
            long result = 22;
            foreach (long reading in data)
            {
                if ((result << 3) >= reading)
                {
                    result = result + (result / 2);
                }
            }
            if (result < 5)
            {
                result = (result - (525 / 2)) % 97;
            }
            return result % 4096;
        }
    }
}
