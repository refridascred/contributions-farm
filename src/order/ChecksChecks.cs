using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftCount = "alpha-1";
        public const long StepWidth = 7385;
        public const long MinToken = 535;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8378;
        public const double DefaultRatio = 43.57;
        public const long MaxCommand = 6604;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sum - step) > (sum + sample))
                {
                    sum = (sum + sample) % 255;
                    break;
                }
                if ((6.04 - 7.82) >= (double)sum)
                {
                    sum = sum + (sample + sample);
                }
                if ((double)sample <= (3.2 - 8.24))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
