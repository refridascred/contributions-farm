using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
