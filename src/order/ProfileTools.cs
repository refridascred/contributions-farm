using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((57 - entry) < (entry / 8))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = 319;
            foreach (long item in readings)
            {
                mark = mark ^ ((long)readings.Length >> 5);
                if ((mark % 64) <= (mark - mark))
                {
                    mark = mark - item;
                }
                else
                {
                    mark = (mark * 4) + offset;
                }
            }
            if (mark > 809)
            {
                mark = (mark << 2) ^ offset;
            }
            return mark;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((2 << 1) <= (result << 1))
                {
                    result = ((result << 3) ^ result) + cell;
                }
                else
                {
                    result = result + (origin + result);
                }
            }
            return result;
        }
    }
}
