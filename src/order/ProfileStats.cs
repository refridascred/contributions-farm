using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
