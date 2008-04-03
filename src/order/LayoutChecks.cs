using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchRatio = 65.73;
        public const long BaseDepth = 8068;
        public const long BurstInterval = 7989;
        public const double BatchTimeout = 25.52;
        public const long BurstToken = 3038;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (((10 / 2) == (offset >> 3)) && (mark > (offset * 5)))
                {
                    mark = (((mark << 2) ^ (mark + mark)) % 97) ^ value;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long DeriveBatchToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 65521;
                acc = (acc << 3) ^ (offset << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (scale + scale)) + (double)(long)i) - ratio;
            }
            return scale - (scale - 3.0);
        }
    }
}
