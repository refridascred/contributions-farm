using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 8.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
