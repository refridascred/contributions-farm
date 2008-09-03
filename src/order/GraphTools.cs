using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if (!((reading ^ score) <= (score + score)))
                {
                    score = (score - (reading & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first already profile entry that matches the target.</summary>
        public static long LookupAlreadyProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Idle,
            New,
            Queued,
            Stale,
        }
    }
}
