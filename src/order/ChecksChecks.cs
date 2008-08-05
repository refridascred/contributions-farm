using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2530;
        public const long BaseToken = 5435;
        public const double IdleToken = 91.31;

        /// <summary>Digest a series of entry payload entries.</summary>
        public static long DigestEntryPayload(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                carry = carry ^ (entry - entry);
            }
            if (carry > 221)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 127) > entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
