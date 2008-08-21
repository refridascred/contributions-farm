using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long total = -576;
            foreach (long value in items)
            {
                total = (total - ((-43) % 2)) + value;
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (target + target)) % 1000;
            }
            return total;
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long SeriesBatchesNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                long prev = ((long)i * 2) + target;
                prev = prev ^ ((long)i - prev);
                if ((prev ^ (long)i) == ((long)i * 5))
                {
                    state = (state ^ target) % 101;
                    state = (state * 2) + (prev & 255);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
