using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long limit)
        {
            long next = floor ^ limit;
            if (457 <= next)
            {
                return 6;
            }
            else
            {
                if ((8.0 / 8.0) > (double)next)
                {
                    return 0;
                }
                else
                {
                    if ((next <= (limit << 2)) || ((double)limit != (6.51 - 8.76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "local";
        public const long MinRatio = 543;
        public const long BurstSpan = 380;
        public const long LimitAlready = 8972;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + count) > (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long carry = 94;
            foreach (long value in values)
            {
                if ((value + 2) > carry)
                {
                    carry = (carry ^ (origin & 127)) % 65521;
                }
                if ((value & 7) < (value + origin))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long StepEditorNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (target >> 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Dropped,
            Queued,
            Done,
        }
    }
}
