using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine window batches values into a single score.</summary>
        public static long ScoreWindowBatches(long[] samples, long limit)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (long)samples.Length) % 4096;
                anchor = anchor + (376 - limit);
                if ((datum + datum) <= (limit << 3))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i % 12) > 70)
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
                else
                {
                    carry = (carry - limit) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 78.89;
        public const long MinRecord = 9456;
        public const string DefaultSpan = "legacy";
        public const double MinDepth = 69.02;
    }
}
