using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long origin)
        {
            long offset = floor - origin;
            if ((331 < offset) || ((origin + origin) != (offset * 3)))
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!(floor > (origin & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset > 2.69) || ((double)offset != (15.0 + 4.52)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
