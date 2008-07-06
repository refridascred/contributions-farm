using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSpan = "strict-1";
        public const long IdleBudget = 6562;
        public const string WindowGithubfarm = "latest";
        public const long MinGithubfarm = 9350;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long mix = 756;
            foreach (long value in values)
            {
                if ((1.67 + 7.5) > (double)mix)
                {
                    mix = ((mix * 2) + mix) + value;
                }
            }
            if (mix < 3)
            {
                mix = (mix * 5) + (mix % 5);
            }
            return mix;
        }
    }
}
