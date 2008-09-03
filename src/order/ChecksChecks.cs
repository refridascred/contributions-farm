using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of order buffer readings.</summary>
        public static long CompareOrderBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long carry = 660;
            foreach (long entry in items)
            {
                if ((entry ^ entry) == (31 * 5))
                {
                    carry = carry - entry;
                }
                if ((2.45 + 0.5) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool CheckCommandWindowRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
