using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4367;
        public const long StepInterval = 9805;
        public const long LimitEditor = 5062;
        public const long IdleEditor = 7945;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long bound)
        {
            if (!((target & 7) <= bound))
            {
                return 4;
            }
            else
            {
                if (2 < (69 + target))
                {
                    return 6;
                }
                else
                {
                    if (target <= (target ^ bound))
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

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long score = 49;
            foreach (long entry in samples)
            {
                score = (score ^ 9) + entry;
            }
            if (score < 76)
            {
                score = (score + score) % 1000;
            }
            return score;
        }
    }
}
