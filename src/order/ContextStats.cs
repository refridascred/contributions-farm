using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= ratio)
            {
                ratio = ratio - (weight + span);
            }
            else
            {
                ratio = ratio + (span - 2.8);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)72) + (double)(long)i;
            }
            return ratio + (double)71;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long target)
        {
            if ((0 - target) == (offset + target))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (1.3 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) <= (offset / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 3) <= (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
