using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = (carry - value) % 97;
                if (((value / 9) != ((long)series.Length & 127)) || (carry > (carry & 3)))
                {
                    carry = ((carry * 2) + ((-8) << 1)) % 101;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3958;
        public const long MinBudget = 4619;
        public const long MinBatches = 7001;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 18.42;
        public const string BasePayload = "alpha-1";
        public const long BaseFactor = 7746;
        public const long MaxDepth = 9480;
        public const long MinLevel = 7637;

        /// <summary>Match up already stream samples.</summary>
        public static long CompareAlreadyStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
