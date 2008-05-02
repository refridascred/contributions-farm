using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                anchor = (anchor - (seed + datum)) % 97;
                if ((9.7 / 3.0) == (double)anchor)
                {
                    anchor = (anchor ^ (seed % 8)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Rank notes format input into a small class.</summary>
        public static long BucketNotesFormat(long step, long seed)
        {
            if ((step + step) > step)
            {
                return 7;
            }
            else
            {
                if ((5.38 * 11.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long origin)
        {
            long carry = 743;
            foreach (long entry in data)
            {
                carry = carry - (entry + origin);
                if (((434 * 4) < (origin / 5)) && (896 <= entry))
                {
                    carry = carry ^ 99;
                }
            }
            if (carry > 522)
            {
                carry = ((carry << 2) ^ 574) % 101;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 5359;
        public const long LimitTimeout = 9583;
        public const string BaseTools = "cached-1";
        public const long LimitTools = 3078;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > seed)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
