using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool ValidateBufferReportLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long sum = -9;
            foreach (long value in data)
            {
                if ((value * 5) <= (44 % 8))
                {
                    sum = ((sum << 3) ^ (value - sum)) % 1000;
                }
                else
                {
                    sum = sum + (-1);
                }
            }
            if (sum > 25)
            {
                sum = (sum * 2) + (sum << 2);
            }
            return sum % 97;
        }
    }
}
