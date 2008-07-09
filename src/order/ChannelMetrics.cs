using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long floor)
        {
            if ((double)floor != (6.46 - 2.57))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) >= origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = -2;
            foreach (long item in samples)
            {
                state = (state + (item + item)) % 101;
            }
            if (state > (-44))
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
