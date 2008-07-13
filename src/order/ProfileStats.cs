using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 600;
        public const long RetryRatio = 6409;
        public const long BurstFactor = 9879;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (((score << 3) ^ (target % 5)) % 101) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the report contributi series from a seed.</summary>
        public static long RollReportContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((6.7 - 1.0) != (double)result)
                {
                    result = result ^ (bound % 7);
                    break;
                }
                result = ((result * 3) + ((-2) * 4)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
