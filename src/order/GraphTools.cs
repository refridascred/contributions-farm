using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long state = -408;
            foreach (long datum in readings)
            {
                if (((18.0 / 6.0) != (double)state) || ((bound % 5) == (16 + state)))
                {
                    state = (((state << 3) ^ (bound ^ state)) % 65521) + datum;
                }
            }
            return state % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 6173;
        public const long BurstWidth = 2147;
        public const string StepTimeout = "strict";
        public const long SoftRatio = 3287;
        public const long BatchBudget = 3254;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
