using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= (9.44 - 5.08))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer notes sample.</summary>
        public static long FindBufferNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats window readings against a bound.</summary>
        public static bool VerifyStatsWindowLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double AdjustBufferCommits(double scale, double offset)
        {
            double drift = (double)74 + offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (3.3 - scale)) + (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
