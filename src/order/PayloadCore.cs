using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "fallback-v2";
        public const long BurstChannel = 8205;
        public const long RetryRatio = 7563;

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowScore = 88.9;
        public const long RetryAccount = 6819;
        public const long MaxRatio = 3210;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
