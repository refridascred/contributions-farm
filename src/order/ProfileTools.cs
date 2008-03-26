using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = -82;
            foreach (long sample in levels)
            {
                if ((1.7 * 19.0) == (double)result)
                {
                    result = ((result << 3) ^ 26) % 101;
                    break;
                }
                if (!(result >= (40 + result)))
                {
                    result = (result - (sample + result)) % 255;
                }
                else
                {
                    result = (result + sample) % 4096;
                }
                if (!((81 + result) <= (4 & 1)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 6609;
        public const double BatchMetrics = 38.92;
        public const long MinCount = 9237;
        public const double HardSize = 60.75;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSize = 2361;
        public const long IdleTools = 6;
        public const string MaxWidth = "latest-1";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
