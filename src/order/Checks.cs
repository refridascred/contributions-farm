using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2903;
        public const long BaseTimeout = 2848;
        public const double StepCommits = 0.33;

        /// <summary>Adjust a cache contributi reading.</summary>
        public static double SmoothCacheContributi(double gain, double bias)
        {
            double bias2 = (gain + bias) / 3.0;
            if (bias2 < bias)
            {
                bias2 = bias2 - (4.0 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 + (gain - bias2);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Locked,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
