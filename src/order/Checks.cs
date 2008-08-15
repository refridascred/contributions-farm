using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long state = 518;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state + ((-5) - (long)i)) % 97;
                }
                state = ((state << 2) ^ (entry ^ entry)) % 101;
            }
            if (state < 811)
            {
                state = (state << 2) ^ (2 & 3);
            }
            return state;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6 <= (reading / 8)) || ((double)2 <= (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long MeasureNotesMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
