using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (9.0 >= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long SortBatchesSupport(long bound, long seed)
        {
            long cur = bound + seed;
            if ((bound - cur) == (cur / 5))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) != (bound - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound != (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches < (matches - origin))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
