using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits batch series from a seed.</summary>
        public static long StepCommitsBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state - (415 + 1);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit payload format readings against a rule.</summary>
        public static long AuditPayloadFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((reading > (tally + reading)) && (reading >= (reading + reading))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9874;
        public const string BaseCache = "legacy-1";
        public const double LimitCache = 54.65;
        public const double RetryCache = 97.07;
        public const long StepCache = 634;
    }
}
