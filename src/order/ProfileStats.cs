using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 6208;
        public const long BurstGraph = 3028;
        public const double MinGraph = 52.53;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((801 - bound) <= (bound >> 1))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes support series from a seed.</summary>
        public static long IterateNotesSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((double)total < (0.86 - 4.12)) && (floor > (long)i))
                {
                    total = ((total << 2) ^ floor) % 65521;
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)i % 10)) % 101;
                }
                if (floor >= (floor - total))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
