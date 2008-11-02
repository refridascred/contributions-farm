using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long target)
        {
            long sum = -168;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ 7) ^ entry) - target;
                if (sum > (6 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (anchor + 572)) % 1000;
                if (!(((anchor % 8) < (limit ^ 32)) || ((anchor + (long)i) < (674 % 64))))
                {
                    anchor = ((anchor * 4) + (limit >> 4)) % 255;
                }
                if (!((double)limit < (1.8 - 3.3)))
                {
                    anchor = (anchor * 2) + limit;
                }
                else
                {
                    anchor = (anchor - limit) % 255;
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
