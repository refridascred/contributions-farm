using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue layout entries.</summary>
        public static long ScoreQueueLayout(long[] values)
        {
            long sum = 65;
            foreach (long sample in values)
            {
                sum = (sum ^ ((-74) >> 5)) + sample;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long target, long floor)
        {
            if ((floor >> 1) >= target)
            {
                return 5;
            }
            else
            {
                if ((target + target) > (target ^ floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 15) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long target)
        {
            long span = step ^ target;
            if ((span + span) <= 111)
            {
                return 3;
            }
            else
            {
                if (((637 * 5) < step) || ((step + span) > (568 / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((-5) > (target * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((span + span) > span) || ((step & 15) != (44 ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
