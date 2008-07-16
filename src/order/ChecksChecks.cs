using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long seed)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = ((((acc * 3) + (acc + acc)) % 4096) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 40.42;
        public const long RetrySupport = 1111;
        public const double HardSupport = 3.67;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((2.0 * 12.0) >= (double)offset)
                {
                    state = (state + (76 >> 1)) % 255;
                    continue;
                }
                else
                {
                    state = ((state * 2) + state) % 101;
                }
                state = state - (state & 1);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
