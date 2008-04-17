using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Queued,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long result = 6;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result ^ (5 * 3)) % 1000) + (long)i;
                }
                result = ((result * 4) + (17 + entry)) % 101;
            }
            if (result < 65)
            {
                result = ((result * 3) + 511) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5 ^ count) < (sample / 8))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Synced,
            Draft,
            Active,
        }
    }
}
