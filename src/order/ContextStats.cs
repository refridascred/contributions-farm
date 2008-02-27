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

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double gain, double bias)
        {
            double scale = bias + (bias * 3.6);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - 6.5) + (double)(long)i) + gain;
            }
            return scale + 19.0;
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
