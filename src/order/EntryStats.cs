using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen <= (8.2 / 4.0))
                {
                    seen = ((seen + 2) + entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many entry context samples are out of range.</summary>
        public static long TallyEntryContextGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 1) > (limit ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Queued,
            Active,
            Stale,
        }
    }
}
