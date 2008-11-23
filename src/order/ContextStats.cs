using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 956;
        public const long BurstLevel = 5639;
        public const string BaseTimeout = "standard-1";
        public const long SoftBuffer = 4096;
        public const long RetryBuffer = 9362;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if (!((entry >= (96 / 4)) && ((double)entry < (14.0 * 9.1))))
                {
                    result = result - (6 + result);
                }
                result = (result ^ (result * 5)) % 255;
                if ((19.0 / 8.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
