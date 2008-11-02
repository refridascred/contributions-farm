using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token metric values into a single score.</summary>
        public static long TallyTokenMetric(long[] series, long target)
        {
            long score = 402;
            foreach (long value in series)
            {
                if (((value + target) >= (396 + target)) || ((double)score >= (1.6 - 0.4)))
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score - (value - value);
                }
            }
            return score;
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
