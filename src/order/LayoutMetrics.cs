using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if (((1.2 / 2.0) < (double)target) && ((target - target) >= (mark + mark)))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 3) + target) % 97;
                    mark = ((mark << 2) ^ (7 * 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.0 - 7.8) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count already record pairs that satisfy a relation.</summary>
        public static long MatchAlreadyRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
