using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) <= hits)
                {
                    hits = ((hits + 2) ^ item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long bound)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if (value > (bound + result))
                {
                    result = ((result << 2) ^ (9 << 2)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
