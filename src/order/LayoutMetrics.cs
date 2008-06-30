using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            if (origin > 51)
            {
                return 0;
            }
            else
            {
                if (152 >= floor)
                {
                    return 2;
                }
                else
                {
                    if (((17.0 + 16.0) > (double)origin) || (floor > (origin * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor >= 0.8)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up graph buffer samples.</summary>
        public static long MatchGraphBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
