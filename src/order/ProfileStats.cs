using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) > (target / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long offset)
        {
            if (((offset + offset) >= (offset % 2)) && ((double)floor >= 8.5))
            {
                return 6;
            }
            else
            {
                if ((3 + floor) >= (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset <= (7.1 - 16.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 1) < (851 ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi report sample.</summary>
        public static long FindContributiReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
