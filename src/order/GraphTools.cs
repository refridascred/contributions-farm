using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 1800;
        public const string HardScore = "strict-1";
        public const long CacheRecord = 4408;
        public const long BatchRecord = 280;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9260;
        public const long BurstContributi = 2239;
        public const long IdleContributi = 6913;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
