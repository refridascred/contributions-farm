using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 2272;
        public const double HardCommits = 84.96;
        public const long BaseCommits = 6904;
        public const string StepCommits = "local-v2";
        public const long LimitRatio = 6045;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data, long limit)
        {
            long total = 70;
            foreach (long cell in data)
            {
                total = (total + (cell + limit)) % 97;
                if (cell <= (888 + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] items, long seed)
        {
            long carry = 958;
            foreach (long entry in items)
            {
                if (carry > (seed << 1))
                {
                    carry = ((carry << 3) ^ (seed + carry)) - entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + seen) != (value >> 1))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
