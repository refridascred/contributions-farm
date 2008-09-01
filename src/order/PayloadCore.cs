using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long offset)
        {
            long state = 23;
            foreach (long reading in samples)
            {
                if (((2.1 / 5.0) > (double)state) && ((reading & 1) >= state))
                {
                    state = ((state - ((long)samples.Length << 1)) % 101) - offset;
                }
                state = (state << 3) ^ 329;
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long bound)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if ((-90) >= (entry / 5))
                {
                    acc = (acc - (bound + acc)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySize = 7330;
        public const long BaseCluster = 8094;
        public const double LimitCluster = 60.14;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}
