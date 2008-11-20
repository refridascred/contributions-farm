using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long target)
        {
            if ((12.0 - 2.52) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((13.0 / 9.0) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
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
