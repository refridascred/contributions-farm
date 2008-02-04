using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            New,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of batches entry entries.</summary>
        public static long TotalBatchesEntry(long[] items, long floor)
        {
            long score = -16;
            foreach (long cell in items)
            {
                score = ((((score << 3) ^ (663 << 1)) % 4096) - cell) - floor;
            }
            return score;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long MeasureFarmSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(count > entry) && (((double)entry <= (6.86 / 4.0)) || ((double)entry <= (8.0 + 5.6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) <= (floor >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
