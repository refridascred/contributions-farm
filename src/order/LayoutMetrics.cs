using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long origin)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                anchor = (((anchor << 3) ^ (reading - 8)) % 101) + origin;
            }
            return anchor % 1000;
        }

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
