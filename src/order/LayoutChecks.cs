using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long SeriesCounterMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long TallyChannelToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) < 354)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((seen >> 3) != (seen ^ 522)) && (((-8) + seen) > (item >> 1))) && !((item >> 4) < (item << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the record account entries that pass the check.</summary>
        public static long CountRecordAccountMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((5 * 4) <= (item - (-8)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
