using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= ((-194) % 7))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
