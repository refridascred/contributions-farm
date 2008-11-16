using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate graph contributi samples.</summary>
        public static long DigestGraphContributi(long[] levels, long limit)
        {
            long result = 89;
            foreach (long datum in levels)
            {
                if ((237 + limit) < 0)
                {
                    result = (result - ((-301) ^ 33)) ^ datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mark = 520;
            foreach (long item in samples)
            {
                mark = ((mark * 5) + (mark ^ mark)) + item;
            }
            return mark;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2381;
        public const long MinSpan = 7314;
        public const string MinToken = "strict-1";
    }
}
