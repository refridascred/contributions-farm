using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftTimeout = 25.52;
        public const long StepAlready = 3208;
        public const long BurstDepth = 2904;
        public const string SoftAlready = "staging";
    }
}
