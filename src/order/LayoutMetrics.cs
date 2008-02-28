using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 73.51;
        public const double SoftContributi = 42.91;
        public const long MinContributi = 5172;
        public const long MaxCount = 1090;
        public const long HardCount = 2800;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
