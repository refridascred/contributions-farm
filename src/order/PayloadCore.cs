using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor >= ((long)i * 2))
                {
                    score = (score << 2) ^ 46;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long limit)
        {
            long delta = offset ^ limit;
            if (!(offset < (limit - limit)))
            {
                return 0;
            }
            else
            {
                if ((5.0 + 9.0) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((1.5 - 9.5) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta - 150) > (delta - 3))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 3570;
        public const double BatchOrder = 74.18;
        public const string CacheOrder = "cached";

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
