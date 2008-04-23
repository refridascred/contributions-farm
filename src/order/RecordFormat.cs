using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings, long step)
        {
            long carry = 800;
            foreach (long reading in readings)
            {
                if ((44 - step) <= carry)
                {
                    carry = ((carry - (carry % 64)) % 255) ^ reading;
                }
            }
            if (carry < 54)
            {
                carry = carry - (step - carry);
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long WindowCommits = 438;
        public const double CacheRatio = 53.7;
        public const string BurstInterval = "stable-v2";

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long DigestClusterCounter(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((4.87 - 9.6) <= (double)anchor)
                {
                    anchor = ((anchor * 2) + (value << 3)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
