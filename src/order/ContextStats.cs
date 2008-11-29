using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Closed,
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long mark = -9;
            foreach (long sample in data)
            {
                mark = (mark * 4) + sample;
                if ((sample % 100) < (sample ^ target))
                {
                    mark = (mark * 4) + 74;
                }
            }
            if (mark > 99)
            {
                mark = ((mark * 4) + (4 - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowFactor = "alpha-v2";
        public const long StepBudget = 1582;
        public const long BurstSchema = 8050;
        public const long BaseSchema = 9040;
        public const string CacheSchema = "cached-edge";

        /// <summary>Find the first session token entry that matches the target.</summary>
        public static long SeekSessionTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
