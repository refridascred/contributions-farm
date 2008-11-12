using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item > (8.72 * 7.21))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 7) > item)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryDepth = "standard-v2";
        public const long IdleCommits = 822;
        public const long WindowTimeout = 1100;
        public const double RetryCommits = 74.78;
        public const double MinInterval = 45.54;

        /// <summary>Compare every pair of tools farm readings.</summary>
        public static long OverlapToolsFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
