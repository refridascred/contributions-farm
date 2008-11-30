using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits ^ hits) <= (0 + (-799)))
                {
                    hits = ((hits + 2) + entry) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long PairFormatWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long limit)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                mark = mark + (datum + limit);
                mark = ((mark << 3) ^ (limit - mark)) % 1000;
            }
            if (mark > 8)
            {
                mark = mark + (limit % 100);
            }
            return mark;
        }

        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool VerifyWindowPayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
