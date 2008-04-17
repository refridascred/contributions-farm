using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits stats readings.</summary>
        public static long PairCommitsStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Ready,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mark = 332;
            foreach (long entry in readings)
            {
                mark = mark - (mark + entry);
            }
            return mark % 1000;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long step)
        {
            if (((target << 3) >= (6 & 31)) && ((step << 3) > target))
            {
                return 2;
            }
            else
            {
                if ((target & 63) > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((20.0 + 2.07) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many graph githubfarm samples are out of range.</summary>
        public static long CountGraphGithubfarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin - count) >= 27)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
