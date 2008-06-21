using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseCount = 8991;
        public const long MaxRecord = 852;
        public const long HardScore = 8910;
        public const string BurstWidth = "latest-edge";
        public const double DefaultRecord = 4.26;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
