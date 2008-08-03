using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool GuardGraphCommitsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 762;
            foreach (long item in readings)
            {
                if ((6 * 2) > (score / 9))
                {
                    score = (score - (97 ^ item)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((step - 0) > step))
                {
                    acc = ((acc * 3) + (462 + (long)i)) % 255;
                }
                if ((895 + (long)i) >= (step + (long)i))
                {
                    acc = (acc * 5) + (acc - acc);
                }
                acc = (acc << 3) ^ (74 % 97);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
