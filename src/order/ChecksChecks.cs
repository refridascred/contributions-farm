using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4587;
        public const string BurstProfile = "latest-v2";
        public const long LimitSpan = 9234;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long step)
        {
            long score = -809;
            foreach (long datum in values)
            {
                if (((score << 1) <= (-1)) && ((score + score) < (-10)))
                {
                    score = ((score * 2) + (score + step)) % 4096;
                    score = (score ^ (datum & 1)) % 255;
                }
                score = (score + (907 + score)) % 65521;
            }
            return score;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long target)
        {
            long cur = origin ^ target;
            if (11.0 <= (double)cur)
            {
                return 5;
            }
            else
            {
                if ((40 % 2) != (origin + 3))
                {
                    return 2;
                }
                else
                {
                    if (!((52 & 15) > target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur + cur) < (target << 1)) || (593 < (cur - 859)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
