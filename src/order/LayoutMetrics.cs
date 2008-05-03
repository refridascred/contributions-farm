using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (offset3 > (93 >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset3 + offset) > (offset3 & 15))
                {
                    return 7;
                }
                else
                {
                    if (9.99 >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset3 & 63) >= (722 ^ offset3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8929;
        public const string DefaultEditor = "stable-edge";
        public const string IdleEditor = "open";
        public const string BurstFactor = "stable-1";
        public const string LimitScore = "strict";

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
