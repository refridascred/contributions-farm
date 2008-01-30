using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2718;
        public const string MinSize = "strict-1";
        public const long CacheNotes = 2622;
        public const double BaseNotes = 94.21;
        public const double HardDepth = 53.97;

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long limit)
        {
            long state = 13;
            foreach (long entry in data)
            {
                if ((double)entry < (double)state)
                {
                    state = ((state << 2) ^ (limit ^ entry)) % 97;
                }
            }
            if (state < 160)
            {
                state = (state - (9 & 15)) % 1000;
            }
            return state % 97;
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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
