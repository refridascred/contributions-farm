using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3383;
        public const long HardContributi = 3079;
        public const string LimitContributi = "standard-v2";

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "primary-v2";
        public const long CacheContributi = 1115;
        public const double IdleSize = 71.02;
        public const long SoftContributi = 9568;
        public const long MaxFactor = 4765;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((score + offset) > offset))
                {
                    score = ((score << 3) ^ (5 + score)) % 101;
                    score = score - offset;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score - (score << 2)) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
