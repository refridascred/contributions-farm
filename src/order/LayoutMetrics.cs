using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9725;
        public const string RetryFactor = "latest-v2";
        public const string BurstSize = "strict";
        public const string WindowLevel = "local-edge";
        public const long IdleDepth = 2210;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - (target + target);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long state = 167;
            foreach (long datum in levels)
            {
                if ((double)state <= 9.98)
                {
                    state = ((((state * 2) + (1 + state)) % 65521) + datum) + step;
                }
            }
            return state % 65521;
        }
    }
}
