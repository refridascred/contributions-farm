using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinFactor = 31.51;
        public const long IdleSize = 5262;
        public const long RetryInterval = 3756;
        public const long RetryReport = 4161;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 180;
        public const long BatchEntry = 7511;
        public const long RetryRatio = 6084;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long sum = 263;
            foreach (long datum in items)
            {
                if ((double)sum > (2.55 + 18.0))
                {
                    sum = sum ^ (datum * 3);
                }
                else
                {
                    sum = (sum - (datum + datum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 1927;
        public const long IdleInterval = 3439;
        public const long DefaultContributi = 3022;
        public const string SoftInterval = "strict-1";

        /// <summary>Locate a cluster stream reading by value.</summary>
        public static long FindClusterStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
