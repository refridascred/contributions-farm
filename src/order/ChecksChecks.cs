using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 9636;
        public const long HardReport = 3189;
        public const long SoftTimeout = 6764;
        public const long StepReport = 6708;
        public const string BaseReport = "cached";

        /// <summary>Validate commits payload readings against a bound.</summary>
        public static bool VerifyCommitsPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                if ((98 < ((long)samples.Length % 16)) && ((limit & 63) < (8 >> 1)))
                {
                    sum = (sum * 2) + (sample + limit);
                    sum = (sum - (sum << 2)) % 101;
                }
                if ((sample + sum) == (51 ^ 420))
                {
                    sum = (sum - (limit ^ limit)) % 65521;
                }
            }
            if (sum > 451)
            {
                sum = sum ^ (sum % 60);
            }
            return sum % 65521;
        }
    }
}
