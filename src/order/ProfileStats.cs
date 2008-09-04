using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            if (13.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor - floor2) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long origin)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if ((score ^ origin) > (entry >> 1))
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    long slot = origin >> 3;
                    score = (score * 3) + slot;
                }
                if (((origin & 63) <= (origin - origin)) && ((double)entry < (double)5))
                {
                    score = (score << 3) ^ (score + entry);
                }
                if ((origin >= (score >> 1)) && ((double)origin < 6.47))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
