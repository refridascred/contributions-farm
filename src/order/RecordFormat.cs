using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (seed >> 4)) % 97;
                mark = mark - (8 - mark);
                if (mark <= seed)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - (long)i) >= (503 >> 2))
                {
                    score = (score + (score % 64)) % 65521;
                    score = score + (score << 1);
                }
                score = (score * 2) + (0 + target);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double bias = floor;
            if (bias < (bias + floor))
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (scale - scale)) + (double)(long)i;
            }
            return bias - 5.0;
        }
    }
}
