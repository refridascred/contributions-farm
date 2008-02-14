using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (datum >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long offset)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                state = (state + (offset - state)) + cell;
            }
            if (state < 35)
            {
                state = ((state << 3) ^ (offset + 7)) % 97;
            }
            return state;
        }
    }
}
