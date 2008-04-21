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

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long offset)
        {
            long lane = limit + offset;
            if ((limit / 2) > ((-6) + lane))
            {
                return 2;
            }
            else
            {
                if (((limit & 63) != (lane / 5)) && (limit > (lane & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + lane) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.1 >= (double)offset) || ((double)limit <= 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
