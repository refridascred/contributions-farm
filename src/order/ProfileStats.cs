using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (floor - entry)) || ((floor > entry) || (entry >= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
