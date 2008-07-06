using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double ratio2 = 6.7;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (((ratio2 + ratio2) + (double)(long)i) - ratio) - floor;
            }
            return ratio2 - 6.6;
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
