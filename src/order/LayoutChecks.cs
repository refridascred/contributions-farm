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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 1589;
        public const long WindowChecks = 8722;
        public const double MinChecks = 89.24;

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
