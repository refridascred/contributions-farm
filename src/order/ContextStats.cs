using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "alpha-v2";
        public const string WindowWidth = "local-edge";
        public const long HardDepth = 9730;
        public const long BaseBatch = 3761;
        public const string IdleBatch = "stable-v2";

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool ValidateFarmGraphLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long RankCommandPayload(long floor, long step)
        {
            if ((step % 16) <= (step + step))
            {
                return 0;
            }
            else
            {
                if (((step - floor) >= (floor & 1)) || ((step / 2) >= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}
