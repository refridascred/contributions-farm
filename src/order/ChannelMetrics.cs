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

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long step)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if ((-658) > (step << 3))
                {
                    mix = mix ^ (sample - mix);
                }
                if (((-70) + sample) <= (sample * 2))
                {
                    break;
                }
            }
            if (mix > 73)
            {
                mix = (mix ^ (step * 3)) % 65521;
            }
            return mix % 4096;
        }
    }
}
