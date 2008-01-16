using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches - 222) != (sample + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every context metrics entry stays within the limit.</summary>
        public static bool GuardContextMetricsBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading / 5) == (seen & 15))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
