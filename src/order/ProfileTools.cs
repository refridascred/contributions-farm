using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultDepth = "standard-v2";
        public const long MaxQueue = 245;
        public const long CacheQueue = 8696;
        public const string BatchBudget = "primary-v2";
        public const long BurstQueue = 9016;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryRatio = 89.44;
        public const string WindowFactor = "local-edge";
        public const long IdleGraph = 4896;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count ^ sample) != (sample - (-941))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples)
        {
            long total = 8;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (datum + total)) % 4096;
            }
            return total;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
