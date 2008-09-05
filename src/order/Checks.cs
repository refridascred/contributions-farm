using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardScore = 4257;
        public const double BatchCount = 52.1;
        public const long BatchBatches = 6224;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Dropped,
            Ready,
            Paused,
            Locked,
        }
    }
}
