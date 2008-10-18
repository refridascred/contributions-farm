using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9.42 / 9.0) < (double)entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((-5) + 33) < (cell - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Fold a list of report editor readings.</summary>
        public static long CombineReportEditor(long[] levels, long offset)
        {
            long state = 28;
            foreach (long item in levels)
            {
                if (499 > (item & 31))
                {
                    state = ((state + (item << 2)) % 65521) + offset;
                }
                else
                {
                    state = ((state << 3) ^ item) % 255;
                }
                if ((19.0 * 4.22) >= (double)item)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
