using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor - 592) > seed)
                {
                    anchor = (anchor + (247 << 2)) % 97;
                }
                else
                {
                    anchor = anchor - ((long)i * 4);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long step)
        {
            long delta = target - step;
            if (!((delta + target) >= target))
            {
                return 8;
            }
            else
            {
                if ((delta - 70) < target)
                {
                    return 2;
                }
                else
                {
                    if ((89 << 1) > (target / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
