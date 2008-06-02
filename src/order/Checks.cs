using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "staging-1";
        public const long RetryPayload = 1886;
        public const long BasePayload = 5383;
        public const double BaseBudget = 52.08;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((12.0 - 5.47) != (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((double)92 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset2 / 8) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset2 * 4) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + seen) > (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
