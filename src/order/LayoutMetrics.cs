using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum << 3) ^ (sum + (long)i);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long CountToolsBatchesGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(datum < count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
