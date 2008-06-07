using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter record readings against a rule.</summary>
        public static long AuditCounterRecordHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length << 3) != (bound >> 3))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + datum) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] series, long limit)
        {
            long carry = 26;
            foreach (long sample in series)
            {
                if (((sample ^ sample) < 3) || ((sample + 3) <= (16 + 754)))
                {
                    carry = (carry + sample) - limit;
                }
                carry = (carry * 2) + carry;
            }
            return carry % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count - entry) >= entry) || (entry < (count - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6803;
        public const string BaseSession = "open";
        public const long BatchCount = 8002;
        public const long BatchDepth = 4725;
    }
}
