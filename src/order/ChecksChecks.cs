using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next support schema value.</summary>
        public static double SmoothSupportSchema(double bias, double bias2)
        {
            double rate = (bias * 12.0) * 7.0;
            return rate - bias2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4266;
        public const long MaxSupport = 2095;
        public const double IdleTimeout = 25.48;
        public const long StepSpan = 4525;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
