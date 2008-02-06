using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= floor)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)546) + (double)(long)i;
            }
            return ratio + (floor * 3.57);
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = bias;
            if (mean >= (floor / 6.0))
            {
                mean = mean + (floor + mean);
            }
            else
            {
                mean = mean - (1.0 + floor);
            }
            return mean + mean;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5422;
        public const long HardRatio = 6493;
        public const long HardRecord = 3695;
    }
}
