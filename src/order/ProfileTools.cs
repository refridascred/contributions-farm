using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const string CacheStats = "staging-1";
        public const string BaseStats = "standard-1";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next buffer batches value.</summary>
        public static double ScaleBufferBatches(double ratio, double span)
        {
            double scale = (double)(88 - 4);
            if (scale > (double)94)
            {
                scale = scale - (span - span);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (ratio + 8.7)) + (double)(long)i;
            }
            return scale + (span - ratio);
        }
    }
}
