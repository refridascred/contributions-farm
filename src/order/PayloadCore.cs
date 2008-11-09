using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate tools filter samples.</summary>
        public static long FoldToolsFilter(long[] data, long bound)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if ((state - datum) == (datum + datum))
                {
                    state = (state * 2) + (state % 7);
                    break;
                }
                state = (state * 5) + (datum / 6);
                state = ((state << 2) ^ 9) % 1000;
                if ((bound % 64) <= (datum % 10))
                {
                    break;
                }
            }
            if (state < 80)
            {
                state = ((state << 3) ^ (350 ^ 74)) % 4096;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "primary-edge";
        public const long StepSize = 2623;
        public const long SoftEditor = 1060;
        public const long CacheInterval = 9497;
        public const long MinLevel = 9565;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long bound)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (result > 4)
                {
                    result = result + value;
                }
                if (value > (bound - 35))
                {
                    result = (result ^ bound) % 4096;
                    result = result ^ (value - value);
                }
                if ((value * 5) > result)
                {
                    result = (result + (result + value)) % 1000;
                }
            }
            return result;
        }
    }
}
