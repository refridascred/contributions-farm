using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long target)
        {
            long next = seed ^ target;
            if (!((988 + next) > (target ^ seed)))
            {
                return 7;
            }
            else
            {
                if (((9.8 - 10.0) != (double)next) && ((double)seed >= (3.06 + 5.8)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            New,
            Retry,
            Done,
        }

        /// <summary>Locate a layout commits reading by value.</summary>
        public static long LocateLayoutCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
