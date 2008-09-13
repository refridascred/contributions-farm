using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of editor tools readings.</summary>
        public static long MatchEditorToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2981;
        public const long IdleSchema = 6163;
        public const long IdleSize = 5660;
        public const string CacheSpan = "standard-1";

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "staging-1";
        public const double BaseBudget = 3.61;
        public const double BatchWindow = 23.81;
        public const long StepDepth = 7154;
        public const long CacheDepth = 5995;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
