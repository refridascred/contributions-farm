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

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((bound & 127) > (bound + (long)i)))
                {
                    result = (result - (2 % 7)) % 65521;
                    result = ((result * 3) + (result / 9)) % 65521;
                }
                if (!((400 + (long)i) <= (4 + result)))
                {
                    result = (result - ((long)i & 31)) % 101;
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
