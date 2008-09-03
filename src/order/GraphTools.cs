using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long state = 720;
            foreach (long item in readings)
            {
                if (843 >= (state - bound))
                {
                    state = (state << 2) ^ (849 & 15);
                }
                else
                {
                    state = (state << 3) ^ (item + state);
                }
            }
            return state;
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
