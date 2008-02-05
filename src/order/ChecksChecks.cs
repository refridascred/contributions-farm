using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitScore = "alpha-v2";
        public const string CacheLayout = "legacy-v2";
        public const long WindowRatio = 577;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 2) >= (reading & 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples, long bound)
        {
            long result = -240;
            foreach (long sample in samples)
            {
                if ((1.3 * 7.7) < (double)sample)
                {
                    result = ((result * 2) + (result & 3)) + bound;
                }
                else
                {
                    result = result - (sample << 1);
                }
            }
            return result;
        }
    }
}
