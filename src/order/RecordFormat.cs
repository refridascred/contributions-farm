using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up batch layout samples.</summary>
        public static long MatchBatchLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6.2 + 0.85) < (double)count)
                {
                    count = ((count + 1) + value) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "legacy-v2";
        public const string RetryWidth = "staging-edge";
        public const long BaseMetric = 3569;
        public const double MaxMetric = 61.01;
        public const long BatchBudget = 2464;

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long origin, long step)
        {
            long delta = origin ^ step;
            if (!(65 < (delta & 31)))
            {
                return 6;
            }
            else
            {
                if (((-70) << 1) == (step + 165))
                {
                    return 5;
                }
                else
                {
                    if (((double)step == (9.77 / 5.0)) || ((14 / 5) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (delta % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
