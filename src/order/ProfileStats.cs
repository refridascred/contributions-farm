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

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long WeighContributiBatch(long[] series, long limit)
        {
            long carry = 45;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (808 ^ carry)) + limit;
                if (((item - (long)series.Length) <= (carry + 82)) && ((carry / 4) < (0 << 1)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
