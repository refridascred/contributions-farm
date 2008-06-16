using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values)
        {
            long anchor = 37;
            foreach (long datum in values)
            {
                anchor = (anchor - (datum + anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((13.0 * 13.0) <= (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long seed)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (3 * 5)) % 97;
                if (sample >= ((long)readings.Length & 3))
                {
                    state = ((state * 5) + (sample ^ seed)) % 1000;
                    state = (state << 2) ^ state;
                }
                if (!((sample & 15) < (sample - (long)readings.Length)))
                {
                    state = (state + (sample * 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((7.0 * 7.0) > (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long origin)
        {
            long lane = step - origin;
            if ((origin ^ lane) >= lane)
            {
                return 1;
            }
            else
            {
                if ((176 < ((-8) - lane)) && ((step >> 5) != (step * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
