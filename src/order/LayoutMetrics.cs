using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long step2 = step + offset;
            if ((double)step2 <= (7.02 * 7.91))
            {
                return 1;
            }
            else
            {
                if ((step * 5) <= (32 ^ 16))
                {
                    return 7;
                }
                else
                {
                    if ((double)2 < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster counter input into a small class.</summary>
        public static long RankClusterCounter(long offset, long origin)
        {
            if (((6.2 - 2.9) < (double)offset) && ((offset << 2) >= origin))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) == (offset - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (offset > (value + 61))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
