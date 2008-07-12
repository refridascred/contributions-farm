using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)818)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long state = 47;
            foreach (long reading in data)
            {
                if (!((reading - 448) > (reading * 5)))
                {
                    state = state + (limit & 63);
                    state = (state + (-9)) % 255;
                }
                if ((limit + limit) < (reading - limit))
                {
                    state = ((state * 2) + (reading - reading)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order buffer input into a small class.</summary>
        public static long ClassifyOrderBuffer(long offset, long origin)
        {
            if ((811 & 63) == (offset - origin))
            {
                return 3;
            }
            else
            {
                if (offset <= (origin ^ 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (6.8 * 4.39))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = result - (entry % 100);
            }
            if (result < 378)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
