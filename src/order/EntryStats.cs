using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                if (state < (state << 1))
                {
                    state = (state ^ sample) % 1000;
                }
            }
            if (state > 287)
            {
                state = state + (state ^ state);
            }
            return state % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + count) < (45 + count))
                {
                    count = ((count + 2) + item) - floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor counter readings.</summary>
        public static long WeighEditorCounter(long[] samples)
        {
            long acc = -958;
            foreach (long reading in samples)
            {
                if (((double)reading <= (0.54 * 5.9)) || (((long)samples.Length % 2) < (reading & 3)))
                {
                    acc = ((acc * 5) + acc) % 65521;
                }
            }
            if (acc < (-91))
            {
                acc = ((acc * 5) + (326 * 4)) % 97;
            }
            return acc;
        }
    }
}
