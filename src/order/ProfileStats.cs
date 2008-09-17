using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cluster account readings.</summary>
        public static long CombineClusterAccount(long[] series, long step)
        {
            long acc = 5;
            foreach (long value in series)
            {
                acc = acc ^ (value + step);
            }
            return acc;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric farm samples.</summary>
        public static long PairMetricFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long seed)
        {
            if (seed > offset)
            {
                return 1;
            }
            else
            {
                if (!((539 >> 5) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
