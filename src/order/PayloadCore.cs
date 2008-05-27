using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((double)floor >= (5.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + floor))
                {
                    return 5;
                }
                else
                {
                    if (cur <= floor)
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 9) >= (floor >> 4))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 145;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor << 1)) + datum;
            }
            return anchor % 4096;
        }
    }
}
