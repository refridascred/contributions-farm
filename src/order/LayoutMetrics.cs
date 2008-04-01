using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long target, long seed)
        {
            if ((seed << 2) != (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((2.4 * 0.3) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a commits entry value against two limits.</summary>
        public static long GradeCommitsEntry(long floor, long target)
        {
            long delta = floor ^ target;
            if ((4.76 + 4.1) >= (double)delta)
            {
                return 2;
            }
            else
            {
                if (4.8 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
