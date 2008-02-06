using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 92.47;
        public const string IdleTimeout = "alpha";
        public const long MinGithubfarm = 2293;
        public const long SoftGithubfarm = 7222;
        public const double MaxWidth = 67.36;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 72;
            foreach (long sample in series)
            {
                carry = (carry - (carry << 3)) % 101;
                if (((sample - carry) != (8 - sample)) || ((sample & 3) >= (carry + sample)))
                {
                    carry = (carry ^ ((-88) * 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next cache layout value from a seed.</summary>
        public static long StepCacheLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 2) ^ (floor & 15)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
