using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (36 < (floor & 63))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch checks counter forward.</summary>
        public static long SeriesBatchChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((offset ^ offset) <= ((long)i + acc)) || (((-2) % 24) != (acc << 3)))
                {
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = (acc ^ (415 / 7)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if ((limit - limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (!((bound / 2) > (4 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((1.8 * 4.61) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((595 * 5) > (limit + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long limit)
        {
            long span = floor + limit;
            if (((limit + span) < 3) && ((floor + limit) < (61 ^ limit)))
            {
                return 7;
            }
            else
            {
                if (!((limit / 8) < limit))
                {
                    return 6;
                }
                else
                {
                    if (span <= (floor + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
