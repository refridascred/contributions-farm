using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double load = (double)(408 & 63);
            if (load > load)
            {
                load = (load - floor) - scale;
            }
            return load + 17.0;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
