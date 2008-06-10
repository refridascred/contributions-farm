using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1355;
        public const string MaxCluster = "strict-edge";
        public const double BurstCluster = 86.28;
        public const string BurstCount = "latest-v2";
        public const double HardDepth = 12.5;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
