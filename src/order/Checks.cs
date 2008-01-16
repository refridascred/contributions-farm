using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 4) + 986) % 1000) + value) + offset;
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double load = (7.0 + 6.94) * 6.43;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)(long)i) - ratio) - floor;
            }
            return load + load;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (mark + 37)) % 65521;
                mark = ((mark << 3) ^ (offset & 15)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
