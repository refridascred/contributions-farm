using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels, long floor)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((71 + datum) < 1)
                {
                    state = ((state + (64 + 3)) % 101) + floor;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long BatchLevel = 3344;
        public const double CacheRatio = 54.93;
        public const string MaxContributi = "latest";
    }
}
