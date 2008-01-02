using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long step, long seed)
        {
            if (step >= (seed - seed))
            {
                return 4;
            }
            else
            {
                if (((8.8 + 3.7) > (double)seed) || ((2.0 + 17.0) == (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (((step + seed) < (67 - step)) && ((double)seed >= (9.3 - 9.67)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Done,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6664;
        public const long DefaultBudget = 746;
        public const double DefaultWidth = 30.42;
    }
}
