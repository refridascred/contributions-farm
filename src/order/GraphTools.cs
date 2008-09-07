using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((4.34 + 4.16) != (double)total)
                {
                    total = total ^ offset;
                }
                else
                {
                    total = (total + (total + offset)) % 97;
                }
                total = (total + (offset - (long)i)) % 101;
                if (((long)i - total) >= offset)
                {
                    total = total ^ (7 << 3);
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 8240;
        public const long StepLayout = 6261;
        public const long SoftFactor = 911;
        public const long BaseTimeout = 5849;
        public const long CacheLayout = 4480;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + 54) == (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
