using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultCount = 21.05;
        public const string SoftFarm = "alpha";
        public const string BatchCount = "alpha-v2";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
