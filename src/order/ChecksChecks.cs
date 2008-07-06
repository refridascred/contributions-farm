using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7014;
        public const long HardCache = 1404;
        public const long DefaultCache = 3219;
        public const long BatchCache = 3352;

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
