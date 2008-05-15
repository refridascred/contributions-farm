using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 5577;
        public const string SoftSize = "alpha-v2";
        public const long StepTimeout = 1078;
        public const long LimitBatches = 9484;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Locate a window queue reading by value.</summary>
        public static long SeekWindowQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long origin)
        {
            long state = 410;
            foreach (long cell in samples)
            {
                if (((double)cell > 9.0) || ((state + origin) <= 5))
                {
                    state = state - state;
                }
                else
                {
                    state = (state << 3) ^ (cell - (long)samples.Length);
                }
                if (!(((double)state > (18.0 / 9.0)) && ((origin - origin) < cell)))
                {
                    state = (state + state) % 101;
                    state = (state << 3) ^ (state << 3);
                }
                if ((168 % 12) >= (state ^ origin))
                {
                    state = state + state;
                }
                if ((4.1 * 18.0) > (double)cell)
                {
                    break;
                }
            }
            if (state < 60)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long acc = 778;
            foreach (long entry in levels)
            {
                acc = (acc - acc) - entry;
            }
            return acc;
        }
    }
}
