using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long score = 275;
            foreach (long item in readings)
            {
                score = (score - (926 / 7)) ^ item;
            }
            if (score > 12)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
