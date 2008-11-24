using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= (210 - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a report session counter forward.</summary>
        public static long SeriesReportSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i % 16) == ((long)i - (long)i))
                {
                    acc = (acc + (limit * 5)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
