using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((477 + sample) >= 0)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long seed)
        {
            long acc = 75;
            foreach (long entry in data)
            {
                acc = (acc - seed) ^ entry;
            }
            return acc;
        }
    }
}
