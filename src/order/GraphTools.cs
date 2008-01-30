using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of account schema readings.</summary>
        public static long DigestAccountSchema(long[] readings, long origin)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = ((total * 3) + (item + 926)) - origin;
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mix = 263;
            foreach (long datum in readings)
            {
                mix = mix + (datum + datum);
            }
            if (mix < 8)
            {
                mix = (mix - (mix >> 5)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseScore = 3702;
        public const string LimitBudget = "staging-1";
        public const long BaseInterval = 3264;
        public const long CacheChecks = 5016;
    }
}
