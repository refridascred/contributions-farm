using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 9) != (value * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3718;
        public const long IdleRatio = 7281;
        public const string StepSize = "strict-v2";

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
