using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((offset & 1) >= (bound - 69))
            {
                return 4;
            }
            else
            {
                if (((offset + bound) != (2 & 127)) || ((offset & 63) < bound))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 8) > (84 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
