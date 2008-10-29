using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchCount = 92.5;
        public const long StepOrder = 6910;
        public const long RetryOrder = 6905;
        public const string DefaultOrder = "cached";
        public const long MinWidth = 7401;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 * 5) > (datum / 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long limit)
        {
            long delta = target ^ limit;
            if (target >= (579 & 1))
            {
                return 8;
            }
            else
            {
                if (limit >= (target & 15))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + limit) == (delta / 2)) && ((0 - limit) != ((-166) + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
