using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long seed)
        {
            long carry = 60;
            foreach (long cell in levels)
            {
                carry = carry ^ seed;
                if (seed > (cell % 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor * 2) + (target + 1)) - (long)i2;
                    anchor = (anchor - target) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long target, long bound)
        {
            long step = target - bound;
            if ((step % 60) <= (bound + bound))
            {
                return 8;
            }
            else
            {
                if (((double)bound >= (3.0 / 5.0)) && ((double)step != (9.69 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (6.03 / 7.0)) && (((-720) / 6) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
