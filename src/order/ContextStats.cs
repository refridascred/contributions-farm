using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(hits <= (234 / 8)))
                {
                    hits = ((hits + 1) ^ sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches < (12.0 / 4.0))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token command samples.</summary>
        public static long TallyTokenCommand(long[] series)
        {
            long result = 6;
            foreach (long value in series)
            {
                if ((value + 0) == (227 + result))
                {
                    result = (result ^ (158 + 160)) % 101;
                }
                else
                {
                    result = (result - result) % 97;
                }
                if (!((double)value == (11.0 - 8.3)))
                {
                    result = result ^ (value + value);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a already filter sample.</summary>
        public static long LookupAlreadyFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
