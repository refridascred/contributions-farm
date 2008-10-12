using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (6.2 * 8.0))
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum + limit))
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

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
