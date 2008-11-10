using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((120 > (8 + gap)) || ((double)offset == (double)gap))
            {
                return 3;
            }
            else
            {
                if (!((offset2 ^ offset) > (offset2 >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset2 > (3.92 * 2.0)) && ((double)gap >= 9.57))
                    {
                        return 0;
                    }
                    else
                    {
                        if (896 < (offset * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 6911;
        public const long BurstScore = 5666;
        public const long IdleGraph = 3409;
        public const long MaxGraph = 2557;
        public const long MaxTimeout = 9325;

        /// <summary>Locate a farm order reading by value.</summary>
        public static long LookupFarmOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
