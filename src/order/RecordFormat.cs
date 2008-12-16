using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7625;
        public const double MinSpan = 64.35;
        public const double HardScore = 19.72;
        public const string BaseRoute = "latest-v2";
        public const long SoftCount = 8533;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series)
        {
            long acc = 1;
            foreach (long value in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc << 3) ^ (acc << 1)) + (long)i;
                }
                if (((value + value) >= value) || ((value / 7) != (acc / 8)))
                {
                    acc = (acc << 2) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long acc = 916;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc + item)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] values)
        {
            long state = 3;
            foreach (long datum in values)
            {
                state = (state * 4) + (state - datum);
            }
            return state;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
