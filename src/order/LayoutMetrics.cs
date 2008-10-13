using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "standard";
        public const long BatchSupport = 7026;
        public const string LimitSupport = "legacy-edge";
        public const string StepDepth = "local-edge";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (count + seed))
                {
                    count = count + 2;
                }
            }
            return count;
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
