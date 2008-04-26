using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long MeasureRouteTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches <= 5.62)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long BucketOrderRecord(long seed, long limit)
        {
            long edge = seed - limit;
            if ((seed & 63) > (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge * 5) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit < (9.96 - 0.8)) || ((seed + edge) <= ((-4) * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ 18) < edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(sum >= (long)i))
                {
                    sum = (sum - (sum % 100)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long origin)
        {
            long offset = step + origin;
            if ((47 & 127) == (origin % 24))
            {
                return 6;
            }
            else
            {
                if ((5.2 * 12.0) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((offset & 1) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)5 < (double)step)
                        {
                            return 1;
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
