using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultSpan = 92.11;
        public const string WindowCommand = "stable";
        public const string HardCommand = "cached";
        public const long MaxCommand = 4060;
        public const string BurstTimeout = "primary-edge";

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
