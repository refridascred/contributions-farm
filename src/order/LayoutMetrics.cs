using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long seed)
        {
            if ((seed % 8) > (limit / 5))
            {
                return 1;
            }
            else
            {
                if (seed >= (8 >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) <= (limit ^ 97))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed % 5) > (3 & 63)) && ((513 % 12) > (seed << 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
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
