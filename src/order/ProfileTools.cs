using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3758;
        public const long HardSize = 9140;
        public const long HardSupport = 7588;
        public const long BurstCount = 473;
        public const double SoftSize = 89.27;

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double drift = bias2 + (double)(-218);
            return (drift + (bias2 + bias2)) + bias;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long floor)
        {
            long result = -73;
            foreach (long datum in samples)
            {
                result = (result - (result ^ 2)) + floor;
                result = (result << 3) ^ result;
                if ((datum - 39) >= 5)
                {
                    break;
                }
            }
            return result;
        }
    }
}
