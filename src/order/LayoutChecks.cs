using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 82.95;
        public const long DefaultInterval = 861;
        public const string MinStats = "primary-1";
        public const double StepStats = 45.59;
        public const long DefaultStats = 4081;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ reading) <= hits) || (((hits + hits) >= hits) && (1 > (hits - reading))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum - datum) != (seed & 31)) || !((19.0 - 0.15) <= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the contributi account entries that pass the check.</summary>
        public static long CountContributiAccountGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= floor)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((-203) < (floor - datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((span / 6) >= (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 31) >= span)
                {
                    return 5;
                }
                else
                {
                    if ((span + bound) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.45 / 7.0) < (0.96 + 5.75))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
