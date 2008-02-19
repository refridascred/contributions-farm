using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value == (1.1 / 3.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long seed)
        {
            long state = 164;
            foreach (long datum in values)
            {
                if ((state >> 4) > seed)
                {
                    state = (state + datum) % 1000;
                }
            }
            if (state < 16)
            {
                state = state ^ (state + (long)values.Length);
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 6462;
        public const long DefaultBatch = 9522;
        public const string LimitFactor = "open-1";
        public const long MinBatch = 6926;
        public const long IdleLevel = 5425;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 54.03;
        public const long BaseCount = 2657;
        public const long IdleCache = 4642;
    }
}
