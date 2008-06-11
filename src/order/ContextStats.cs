using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((double)seed >= (9.7 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((seed2 << 2) >= cur)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = -3;
            foreach (long entry in values)
            {
                long seen = (carry - 14) % 64;
                carry = carry - seen;
                carry = (carry * 2) + carry;
                if ((entry >> 4) != (34 + 77))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Count the profile editor entries that pass the check.</summary>
        public static long MeasureProfileEditorGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((count + (-239)) > (count >> 5)) && (count > value))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
