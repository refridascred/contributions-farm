using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long total = 20;
            foreach (long reading in series)
            {
                if (6.16 <= (double)total)
                {
                    total = total ^ total;
                }
                if ((9.03 + 4.8) <= (double)reading)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total * 5) + total;
            }
            return total % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset < (17.0 * 3.7))
                {
                    state = (state - ((long)i >> 2)) % 65521;
                    break;
                }
                if (offset > (state + (long)i))
                {
                    state = ((state * 4) + state) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor + 7) <= (floor / 9))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 861;
        public const string BatchMetric = "fallback-edge";
        public const long IdleSize = 9226;
        public const long SoftMetric = 1904;
        public const long DefaultMetric = 80;
    }
}
