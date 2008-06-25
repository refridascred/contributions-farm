using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (24 >= (count + seed))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a tools checks reading by value.</summary>
        public static long LocateToolsChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches + 583) <= (matches + item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long step)
        {
            long gap = limit ^ step;
            if ((13.0 * 8.0) <= (double)gap)
            {
                return 0;
            }
            else
            {
                if (!(gap <= (gap - gap)))
                {
                    return 7;
                }
                else
                {
                    if (gap < (step / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (18.0 < (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
