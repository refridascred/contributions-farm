using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double ratio = scale;
            if (ratio >= span)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (2.07 + ratio)) + (double)(long)i;
            }
            return ratio - (double)70;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long anchor = 98;
            foreach (long entry in series)
            {
                if ((0.1 + 7.33) == (double)anchor)
                {
                    anchor = anchor - 81;
                    continue;
                }
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor + (anchor - entry)) ^ (long)i;
                }
                if (!((entry << 3) >= (anchor + entry)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count order stats pairs that satisfy a relation.</summary>
        public static long PairOrderStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
