using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long mix = -15;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (datum >= (datum * 3))
                {
                    mix = (mix << 3) ^ (mix & 127);
                }
            }
            if (mix < (-595))
            {
                mix = ((mix << 2) ^ ((long)levels.Length % 2)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Ready,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (limit < entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
