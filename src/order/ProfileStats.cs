using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)2 < (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long diff = floor + seed;
            if (676 > floor)
            {
                return 0;
            }
            else
            {
                if (floor < (diff / 4))
                {
                    return 6;
                }
                else
                {
                    if (6 >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + floor) != (floor << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
