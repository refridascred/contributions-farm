using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((seed + cell) < (195 & 15)) && (17.0 >= (double)seed)) && ((hits & 63) < (cell - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Closed,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
