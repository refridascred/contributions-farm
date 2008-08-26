using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((13.0 + 1.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((offset * 4) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long CountPayloadTokenGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (0.29 / 3.0))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
