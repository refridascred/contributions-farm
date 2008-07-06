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

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
