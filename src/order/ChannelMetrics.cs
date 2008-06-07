using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seed) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Active,
            Paused,
        }
    }
}
