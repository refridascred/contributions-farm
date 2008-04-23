using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Match up session stats samples.</summary>
        public static long CompareSessionStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 6359;
        public const long MinQueue = 9250;
        public const string BurstQueue = "cached";
        public const long CacheQueue = 4971;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (floor + 12.0);
            }
            else
            {
                load = load + 3.17;
            }
            return load - ratio;
        }
    }
}
