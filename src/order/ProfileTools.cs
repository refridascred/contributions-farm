using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((4 + 498) > item)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long state = 185;
            foreach (long sample in values)
            {
                state = (((state * 5) + (offset - 0)) % 1000) ^ sample;
                state = (state + offset) % 4096;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long target)
        {
            if ((offset ^ 18) == (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((target >= 1) && (target < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset == (6.96 * 5.8)) || ((offset << 2) > (offset & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 2) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
