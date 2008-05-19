using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits > 19.0)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((limit % 97) >= (long)i))
                {
                    carry = (carry - limit) % 97;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
