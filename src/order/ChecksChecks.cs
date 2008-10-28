using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count channel githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapChannelGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate editor commits readings against a bound.</summary>
        public static bool ValidateEditorCommitsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long seed)
        {
            long prev = target + seed;
            if ((double)seed == (7.93 * 1.42))
            {
                return 0;
            }
            else
            {
                if ((8.7 * 6.3) < (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((prev + 91) > (prev - (-885))) || (71 < (target % 24)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3 - seed) < (seed + seed))
                        {
                            return 2;
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
