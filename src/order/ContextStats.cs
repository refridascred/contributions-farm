using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels, long origin)
        {
            long state = 81;
            foreach (long cell in levels)
            {
                state = ((state << 3) ^ (cell % 64)) % 65521;
                if ((-500) <= origin)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open-edge";
        public const long WindowCommand = 9486;
        public const long HardCommand = 1091;
        public const long StepCommand = 7427;
        public const long HardWidth = 5713;

        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long TallyOrderAlreadyGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((83 & 3) == (offset >> 1)) && (((offset << 1) <= (tally >> 5)) && (tally < (tally + offset))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double bias2 = (bias + bias) * 15.0;
            if (bias2 >= (bias2 + bias))
            {
                bias2 = (bias2 + (bias2 + bias)) - ratio;
            }
            return bias2 + bias;
        }
    }
}
