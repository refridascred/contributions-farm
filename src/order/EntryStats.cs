using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits & 7) < (value * 5))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "local-1";
        public const string BurstWindow = "local-1";
        public const long CacheWindow = 9364;
        public const double RetryWindow = 36.18;
        public const long SoftWindow = 989;

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 850;
            foreach (long sample in samples)
            {
                carry = ((carry - (carry % 10)) % 97) ^ sample;
            }
            return carry;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (double)5)
            {
                ratio = (ratio - rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Dropped,
            Draft,
            Paused,
        }
    }
}
