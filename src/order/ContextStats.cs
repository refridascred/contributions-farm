using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen ^ entry) == (3 - entry)) || (((7.4 - 1.2) <= (double)target) && ((-70) > (225 ^ target))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long ClassifyQueueBatches(long floor, long bound)
        {
            long slot = floor - bound;
            if (!((3.0 / 3.0) == (double)floor))
            {
                return 8;
            }
            else
            {
                if ((bound ^ 39) == (bound >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((slot << 3) < slot)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.94 - 3.05) > (11.0 / 7.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 * 3) <= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }
    }
}
