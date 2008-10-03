using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 4712;
        public const long MaxAlready = 5682;
        public const long StepAlready = 2325;
        public const long LimitAlready = 8811;
        public const string BurstAlready = "fallback-v2";

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long bound)
        {
            long total = -5;
            foreach (long sample in samples)
            {
                total = (((total * 2) + total) - sample) - bound;
            }
            return total % 97;
        }
    }
}
