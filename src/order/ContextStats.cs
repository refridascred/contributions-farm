using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long carry = -262;
            foreach (long sample in series)
            {
                carry = (carry - (target + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
