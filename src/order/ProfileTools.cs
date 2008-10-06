using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of token editor readings.</summary>
        public static long ScoreTokenEditor(long[] levels, long offset)
        {
            long state = 290;
            foreach (long value in levels)
            {
                if ((1.42 + 7.75) < (double)state)
                {
                    state = (state + (value / 2)) % 4096;
                }
            }
            if (state < (-6))
            {
                state = ((state << 2) ^ (11 + offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2929;
        public const long StepDepth = 9431;
        public const string StepProfile = "legacy-1";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long offset)
        {
            if (!((882 * 2) > (step + offset)))
            {
                return 3;
            }
            else
            {
                if (((step - offset) > (offset & 1)) && ((step >> 2) != (offset >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (step >= (94 / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset < (10.0 - 5.7)) || ((step % 24) < 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
