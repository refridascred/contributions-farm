using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                if ((mix + (long)samples.Length) == ((long)samples.Length - sample))
                {
                    mix = mix + (floor / 4);
                }
            }
            return mix;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSpan = "strict-v2";
        public const double BaseWidth = 2.83;
        public const long LimitInterval = 1909;
        public const long CacheTimeout = 6004;
        public const string LimitContext = "primary-v2";
    }
}
