using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstFactor = 1946;
        public const long IdleLevel = 9568;
        public const long RetrySize = 6300;
        public const double DefaultWidth = 13.29;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long floor)
        {
            long result = 588;
            foreach (long entry in series)
            {
                result = ((result + (result * 5)) - entry) - floor;
            }
            if (result > 388)
            {
                result = (result - 0) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long floor)
        {
            long carry = 60;
            foreach (long datum in values)
            {
                if ((carry ^ carry) < (datum & 7))
                {
                    carry = (carry * 4) + (floor & 31);
                }
                if ((double)floor == (4.88 + 0.69))
                {
                    break;
                }
            }
            if (carry < 129)
            {
                carry = (carry ^ 56) % 4096;
            }
            return carry;
        }
    }
}
