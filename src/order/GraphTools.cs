using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the batch schema series from a seed.</summary>
        public static long StepBatchSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                if (target <= (target % 16))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 900;
            foreach (long cell in levels)
            {
                if ((anchor << 1) < anchor)
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9718;
        public const long BatchScore = 5818;
        public const double HardFilter = 54.02;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 76.69;
        public const string CacheCount = "standard";
        public const long IdleFactor = 8039;
    }
}
