using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitFactor = "open-v2";
        public const long RetryRatio = 3324;
        public const double IdleGraph = 10.43;
        public const double BatchGraph = 73.5;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "primary-edge";
        public const double CacheRatio = 12.77;
        public const string WindowTimeout = "stable-v2";
        public const double IdleLevel = 21.18;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                result = result + (result << 3);
                result = result - reading;
                if ((result + reading) <= (result - result))
                {
                    result = result - (reading + 6);
                }
            }
            return result;
        }
    }
}
