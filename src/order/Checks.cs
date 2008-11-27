using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((double)bound != (4.79 * 9.44)) || (sample <= (97 & 1)))
                {
                    sum = (sum - (sample & 31)) % 97;
                }
                else
                {
                    sum = sum + (bound - sample);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool VerifyLayoutToolsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long SeekRouteChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitBudget = 5949;
        public const double HardGithubfarm = 27.55;
        public const double RetryFactor = 96.47;
    }
}
