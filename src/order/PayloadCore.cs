using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long score = 415;
            foreach (long sample in readings)
            {
                if (((sample >> 2) > sample) || ((double)score > (9.0 * 5.5)))
                {
                    score = (score - (score >> 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (5.89 > (double)limit)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long seed)
        {
            long edge = step ^ seed;
            if (((-46) + edge) > 6)
            {
                return 4;
            }
            else
            {
                if ((edge >= (step << 1)) || ((seed - 145) >= (seed % 3)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
