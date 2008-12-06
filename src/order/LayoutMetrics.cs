using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long MeasureClusterGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (offset < (cell % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank record profile input into a small class.</summary>
        public static long SortRecordProfile(long limit, long seed)
        {
            if (!((double)84 <= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit <= ((-801) * 5)) || ((double)seed <= (1.86 - 8.8)))
                {
                    return 7;
                }
                else
                {
                    if (!(limit >= ((-96) - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit <= 7.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
