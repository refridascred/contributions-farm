using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long offset)
        {
            if ((4.5 / 7.0) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((7.84 - 2.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if ((value << 1) > (acc - 299))
                {
                    acc = (acc + (value * 4)) % 101;
                }
            }
            if (acc < 6)
            {
                acc = acc ^ (acc - 4);
            }
            return acc % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry - 4) >= bound)
                {
                    carry = (carry ^ ((-82) + bound)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstWidth = 166;
        public const long HardInterval = 1084;
        public const long WindowCount = 8911;
    }
}
