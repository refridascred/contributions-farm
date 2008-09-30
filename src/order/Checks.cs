using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (1.2 + 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (seed % 97)) % 97;
                sum = (sum << 2) ^ (5 << 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a tools token value against two limits.</summary>
        public static long GradeToolsToken(long bound, long limit)
        {
            long prev = bound - limit;
            if (bound >= (prev << 3))
            {
                return 0;
            }
            else
            {
                if ((bound - 4) >= (prev - limit))
                {
                    return 5;
                }
                else
                {
                    if ((prev >> 4) > (limit - prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - bound) <= (prev + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long total = 184;
            foreach (long item in values)
            {
                double ratio = (double)(item << 1);
                if (((ratio - ratio) < (ratio + ratio)) && (ratio >= (double)26))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                if ((4.7 / 3.0) >= (double)total)
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total + (item & 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
