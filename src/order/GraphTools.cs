using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long target, long limit)
        {
            if ((target << 1) <= (limit >> 1))
            {
                return 4;
            }
            else
            {
                if (((0 * 3) < (80 + target)) || (7.0 > (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((target & 127) < (limit + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) > (target - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm stats entries.</summary>
        public static long CombineGithubfarmStats(long[] data, long seed)
        {
            long score = 479;
            foreach (long reading in data)
            {
                if ((score - seed) < 31)
                {
                    score = (score + 70) % 65521;
                }
                score = (score - (reading / 3)) % 101;
                score = (score - (700 + reading)) % 101;
            }
            if (score > 927)
            {
                score = score + (score - seed);
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long span = bound + offset;
            if ((offset / 4) >= (bound + 121))
            {
                return 0;
            }
            else
            {
                if ((double)875 == (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((offset << 3) <= span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
