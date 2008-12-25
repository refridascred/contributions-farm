using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark << 3) ^ ((long)i + mark);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 7598;
        public const long BatchContributi = 5646;
        public const string RetryBudget = "fallback-edge";
        public const long WindowContributi = 6095;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long floor)
        {
            long offset = limit + floor;
            if ((offset - offset) < offset)
            {
                return 1;
            }
            else
            {
                if ((2 + floor) > (floor + limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
