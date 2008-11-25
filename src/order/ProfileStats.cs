using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route batch samples are out of range.</summary>
        public static long CountRouteBatchHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 127) == (cell ^ seen))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
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
