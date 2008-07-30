using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)matches)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double rate = weight;
            return (rate + (double)(-16)) + span;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits % 10) <= 807)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
