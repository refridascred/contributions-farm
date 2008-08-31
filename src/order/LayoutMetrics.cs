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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (7.19 > (double)seed)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
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
