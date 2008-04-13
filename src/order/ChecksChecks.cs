using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 5980;
        public const long RetryCluster = 7391;
        public const string MinCluster = "cached-edge";
        public const long BatchCluster = 4907;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long state = 741;
            foreach (long datum in samples)
            {
                if ((double)state == (double)datum)
                {
                    state = (state * 2) + (datum - state);
                }
                else
                {
                    state = state - (state * 2);
                }
                if ((double)datum <= (9.95 / 3.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
