using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long total = -3;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ datum) % 101;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-edge";
        public const double BaseNotes = 68.94;
        public const double BurstRatio = 75.63;
    }
}
