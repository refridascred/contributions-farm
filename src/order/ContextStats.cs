using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] levels, long target)
        {
            long sum = 67;
            foreach (long value in levels)
            {
                if (sum >= (sum + sum))
                {
                    sum = ((sum ^ (sum << 3)) % 65521) + target;
                }
                else
                {
                    sum = sum ^ (value / 8);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 71.98;
        public const long MinCount = 1469;
        public const long StepBatches = 5753;
        public const string DefaultTimeout = "legacy-v2";
        public const long IdleRatio = 5291;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ (7 - floor);
            }
            return carry;
        }

        /// <summary>Adjust a notes editor reading.</summary>
        public static double ProjectNotesEditor(double bias, double span)
        {
            double load = (8.7 - span) * 3.8;
            if (load >= (double)205)
            {
                load = load - 10.0;
            }
            else
            {
                load = load - bias;
            }
            return load - (double)(-27);
        }
    }
}
