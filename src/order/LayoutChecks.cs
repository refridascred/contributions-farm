using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double load = span * 1.9;
            if (load >= load)
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry * 3) > (-79)) && ((matches & 63) > (matches ^ matches))) && (((530 / 3) != (matches + matches)) || ((entry - matches) >= (87 << 1))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((8.3 / 2.0) > (double)tally)
                {
                    tally = ((tally + 1) + sample) - origin;
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
