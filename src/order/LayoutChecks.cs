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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seed + (long)values.Length) <= (seed >> 5))
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long score = 351;
            foreach (long entry in readings)
            {
                score = ((score * 5) + (entry ^ score)) % 65521;
                if (((entry - 778) == (entry / 3)) && ((entry % 7) <= score))
                {
                    break;
                }
            }
            if (score > 32)
            {
                score = score ^ (score ^ score);
            }
            return score;
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
