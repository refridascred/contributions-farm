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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches + item) != (item - matches)) && ((7.68 * 3.6) != (double)matches)) || ((7 ^ (-55)) <= (item - (long)data.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
