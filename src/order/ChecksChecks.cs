using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long GradeAccountQueue(long limit, long bound)
        {
            long next = limit + bound;
            if (next >= bound)
            {
                return 0;
            }
            else
            {
                if ((limit << 1) > (limit / 2))
                {
                    return 3;
                }
                else
                {
                    if ((limit - next) > (limit + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long target2)
        {
            long cur = target + target2;
            if (cur >= ((-912) & 15))
            {
                return 0;
            }
            else
            {
                if (((target2 & 63) != (target >> 3)) && (target <= (target2 & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((7.0 + 3.0) >= (double)target2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
