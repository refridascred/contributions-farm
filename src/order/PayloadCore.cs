using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3761;
        public const long CacheSupport = 6703;
        public const string IdleSupport = "legacy-1";
        public const long RetrySupport = 8669;
        public const long BurstSupport = 7670;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
