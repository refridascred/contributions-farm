using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3002;
        public const long BurstWidth = 1924;
        public const long MaxSpan = 5512;
        public const string StepSchema = "primary-edge";
        public const long BaseSpan = 8617;

        /// <summary>Audit support buffer readings against a rule.</summary>
        public static long AuditSupportBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 31) >= (entry & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long AuditCounterReportMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + target) == (reading / 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
