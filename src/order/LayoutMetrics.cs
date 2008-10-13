using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double offset)
        {
            double rate = (double)426 / 5.0;
            if (rate <= (double)6)
            {
                rate = (rate - rate) - scale;
            }
            return rate + offset;
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
