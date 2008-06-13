using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long gap = target - step;
            if ((target >> 2) > (gap + step))
            {
                return 1;
            }
            else
            {
                if (((step / 3) >= (gap + step)) && ((gap - target) > (step + 8)))
                {
                    return 6;
                }
                else
                {
                    if ((target / 9) >= (target - (-2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a cluster stats counter forward.</summary>
        public static long StepClusterStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                if (state >= (state - state))
                {
                    state = (state << 3) ^ (-1);
                    continue;
                }
                state = (state << 3) ^ ((long)i - (long)i);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
