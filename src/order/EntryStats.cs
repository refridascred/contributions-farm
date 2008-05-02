using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Idle,
            Dropped,
            Done,
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
