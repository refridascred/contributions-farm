using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((19.0 - 0.86) != (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics checks samples are out of range.</summary>
        public static long CountMetricsChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (1.7 - 7.4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + acc) - value;
                if (((-293) / 9) <= (acc / 2))
                {
                    acc = acc + (60 & 127);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (step - 6)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long limit)
        {
            if (((double)target <= (double)limit) && ((target / 5) != (target + limit)))
            {
                return 1;
            }
            else
            {
                if (limit <= target)
                {
                    return 7;
                }
                else
                {
                    if ((target ^ target) >= (limit & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + limit) < target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
