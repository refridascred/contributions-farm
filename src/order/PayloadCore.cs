using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinScore = 93.84;
        public const long DefaultCount = 3341;
        public const long StepDepth = 5360;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "staging-1";
        public const long LimitInterval = 9214;
        public const long BurstCount = 384;
        public const long BatchSpan = 9638;
        public const long BurstGithubfarm = 6343;
    }
}
