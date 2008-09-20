using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowBudget = "fallback-v2";
        public const long BaseScore = 28;
        public const long CacheFarm = 6919;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Active,
            Retry,
            Dropped,
        }
    }
}
