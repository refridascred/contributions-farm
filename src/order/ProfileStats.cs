using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long acc = 877;
            foreach (long datum in items)
            {
                acc = ((acc ^ (216 + step)) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (limit >= (cell % 16))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine layout account values into a single score.</summary>
        public static long DigestLayoutAccount(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (((score * 4) + (score >> 3)) % 97) + cell;
            }
            if (score < 927)
            {
                score = (score ^ (score & 63)) % 97;
            }
            return score;
        }
    }
}
