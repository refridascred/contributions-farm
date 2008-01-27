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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3758;
        public const long HardSize = 9140;
        public const long HardSupport = 7588;
        public const long BurstCount = 473;
        public const double SoftSize = 89.27;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
