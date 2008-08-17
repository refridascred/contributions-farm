using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long RankPayloadRecord(long step, long offset)
        {
            if (step >= (64 - 280))
            {
                return 4;
            }
            else
            {
                if (((-721) << 1) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((step - offset) <= (offset << 2))
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
