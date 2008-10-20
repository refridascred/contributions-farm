using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long AuditMetricsCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - 85) == (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long bound)
        {
            if ((1.0 + 4.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 4.8)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) <= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
