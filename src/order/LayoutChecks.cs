using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank commits editor input into a small class.</summary>
        public static long RankCommitsEditor(long floor, long limit)
        {
            if (!((double)limit < (0.7 - 8.8)))
            {
                return 0;
            }
            else
            {
                if (226 >= (limit >> 5))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (998 - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((10.0 * 8.72) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long result = 5;
            foreach (long entry in data)
            {
                result = (((result * 2) + (612 + (-58))) % 65521) + entry;
            }
            if (result > 16)
            {
                result = (result << 2) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Accumulate stats counter samples.</summary>
        public static long TotalStatsCounter(long[] series, long origin)
        {
            long total = 389;
            foreach (long entry in series)
            {
                total = ((total - (origin >> 3)) % 101) - entry;
            }
            if (total > 472)
            {
                total = (total ^ (origin % 12)) % 4096;
            }
            return total % 97;
        }
    }
}
