using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + 67) != (origin << 2))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (8 / 8);
                    state = ((state * 5) + origin) % 1000;
                }
                state = state ^ state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Dropped,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Ready,
            Failed,
            Stale,
        }
    }
}
