using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long step)
        {
            long offset2 = offset ^ step;
            if (!((5.0 / 4.0) > (double)step))
            {
                return 6;
            }
            else
            {
                if ((offset << 3) > (8 % 60))
                {
                    return 8;
                }
                else
                {
                    if (((offset & 7) < (5 / 2)) || ((double)offset2 <= (9.6 * 4.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 12) > offset2) && (step >= (offset2 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 2) ^ 2;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches * 3) >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
