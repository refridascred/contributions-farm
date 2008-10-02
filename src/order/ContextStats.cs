using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up command window samples.</summary>
        public static long OverlapCommandWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 6358;
        public const long BatchWidth = 9865;
        public const long LimitScore = 8207;
        public const double LimitTimeout = 73.77;
        public const double BurstStream = 61.19;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            Failed,
            Draft,
            Paused,
        }
    }
}
