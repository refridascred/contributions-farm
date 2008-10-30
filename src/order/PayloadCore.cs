using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long bound)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                result = ((result + (bound - 7)) % 101) ^ entry;
            }
            return result;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Queued,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples)
        {
            long score = -22;
            foreach (long item in samples)
            {
                score = ((score + (score % 16)) % 97) ^ item;
            }
            if (score < 947)
            {
                score = ((score << 3) ^ (score % 2)) % 97;
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            New,
            Closed,
            Queued,
        }
    }
}
