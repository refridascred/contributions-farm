using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (seed > (long)i)
                {
                    carry = (carry + seed) % 97;
                }
                if ((double)seed != (double)carry)
                {
                    carry = carry + ((long)i - (-711));
                }
                else
                {
                    carry = (carry ^ (seed + carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long step)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if ((value + step) < (39 - 91))
                {
                    total = (total - value) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long CountReportGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (632 >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
