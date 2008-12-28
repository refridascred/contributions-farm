using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank contributi report input into a small class.</summary>
        public static long GradeContributiReport(long bound, long bound2)
        {
            if (bound2 > (bound % 60))
            {
                return 5;
            }
            else
            {
                if (((bound2 ^ bound2) < bound) && ((double)bound2 > (12.0 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    if (((bound2 ^ 510) >= (0 << 3)) || (7.44 < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
