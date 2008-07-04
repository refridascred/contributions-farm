using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 105;
        public const string LimitDepth = "latest-v2";
        public const long MinWindow = 7048;
        public const long CacheSize = 7445;
        public const long LimitWindow = 1819;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(7.1 >= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
