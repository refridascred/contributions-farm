using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheSize = 42.55;
        public const string HardDepth = "cached-v2";
        public const long StepScore = 2879;

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2965;
        public const double WindowBudget = 39.06;
        public const double IdleGraph = 49.21;
        public const long BaseGraph = 9951;
        public const long BatchGraph = 5200;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowScore = 4010;
        public const double DefaultRatio = 15.98;
        public const double IdleRecord = 80.45;
    }
}
