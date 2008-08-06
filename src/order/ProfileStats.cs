using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc ^ (item + 42);
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 60);
            }
            return acc;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long target, long origin)
        {
            long diff = target - origin;
            if (diff >= (diff % 97))
            {
                return 6;
            }
            else
            {
                if ((double)diff < (6.72 - 4.4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a layout support counter forward.</summary>
        public static long StepLayoutSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if ((14.0 + 2.1) >= (double)score)
                {
                    continue;
                }
                score = score ^ (score + 0);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
