using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "local";
        public const long LimitPayload = 2663;
        public const double SoftPayload = 24.92;

        /// <summary>Audit account command readings against a rule.</summary>
        public static long CountAccountCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((double)seen >= 8.2) && (((double)value >= (6.0 - 9.1)) && ((1.62 / 5.0) != (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((value << 2) < hits))
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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
