using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine queue account values into a single score.</summary>
        public static long FoldQueueAccount(long[] items)
        {
            long carry = 992;
            foreach (long item in items)
            {
                carry = ((carry * 4) + carry) % 4096;
                carry = (carry * 4) + (item / 3);
                if (item > carry)
                {
                    carry = (carry + ((-20) & 255)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < (409 - hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up schema session samples.</summary>
        public static long OverlapSchemaSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
