using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch checks counter forward.</summary>
        public static long RollBatchChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + ((long)i & 63)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
