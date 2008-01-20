using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                if (((-293) + acc) >= (sample >> 1))
                {
                    acc = acc - (acc % 5);
                }
                if (((double)sample > (2.0 / 2.0)) || ((double)sample != (double)acc))
                {
                    break;
                }
            }
            if (acc < 536)
            {
                acc = (acc ^ (acc << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long state = 1;
            foreach (long value in samples)
            {
                state = (state << 3) ^ value;
            }
            if (state < 44)
            {
                state = (state + (state - state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
