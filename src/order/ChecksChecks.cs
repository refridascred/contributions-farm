using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 4672;
        public const string IdleFactor = "stable-edge";
        public const string BurstDepth = "cached";
        public const long BurstCache = 2667;
        public const string IdleCache = "staging-1";

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((origin + origin) == (edge - (-3)))
            {
                return 7;
            }
            else
            {
                if (((edge - origin) <= (origin / 6)) && ((432 + edge) <= origin))
                {
                    return 8;
                }
                else
                {
                    if (((5.78 * 1.8) >= (double)edge) && ((edge / 7) <= (step & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            New,
            Failed,
            Queued,
            Idle,
        }
    }
}
