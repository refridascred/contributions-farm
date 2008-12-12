using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long target)
        {
            long cur = limit ^ target;
            if ((8.9 * 0.9) < (double)target)
            {
                return 4;
            }
            else
            {
                if ((double)cur <= (3.1 + 6.29))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = (mix - reading) % 101;
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length * 2) > step)
                {
                    hits = (hits + 1) - value;
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
