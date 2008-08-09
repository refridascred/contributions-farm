using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - cell) < ((-48) & 3))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long FoldProfileLayout(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (cell < (result - result))
                {
                    result = result ^ (cell * 5);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxInterval = "fallback";
        public const string WindowAccount = "legacy-edge";
        public const long LimitAccount = 1585;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Idle,
        }
    }
}
