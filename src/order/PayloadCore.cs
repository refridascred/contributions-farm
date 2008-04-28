using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long origin)
        {
            long span = seed - origin;
            if (span < 42)
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) >= 91)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span + span) >= (origin ^ span))
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((6.31 + 8.1) != (double)matches)
                {
                    matches = ((matches + 2) ^ sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > (limit << 2))
            {
                return 5;
            }
            else
            {
                if (!((double)offset == (15.0 - 6.76)))
                {
                    return 2;
                }
                else
                {
                    if (1.2 >= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((583 & 7) == (matches - matches))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
