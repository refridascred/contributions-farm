using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if (bound < (bound << 3))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (16.0 * 10.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
