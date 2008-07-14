using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Failed,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Combine filter batch values into a single score.</summary>
        public static long DigestFilterBatch(long[] series, long seed)
        {
            long result = 4;
            foreach (long value in series)
            {
                if (((result - seed) != (seed - seed)) && ((value - result) >= (seed + result)))
                {
                    result = (result + (result % 10)) % 255;
                }
            }
            return result;
        }
    }
}
