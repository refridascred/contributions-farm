using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long seed)
        {
            if ((16 % 97) != (step >> 4))
            {
                return 6;
            }
            else
            {
                if ((step % 10) >= (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if (((9.1 + 4.6) <= (double)step) && ((6.0 + 7.0) != (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 1081;
        public const long StepWidth = 8872;
        public const double BurstGithubfarm = 44.25;
        public const double BaseGithubfarm = 22.21;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
