using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9297;
        public const long BurstScore = 7940;
        public const long BurstSpan = 3411;
        public const long DefaultReport = 7309;

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long StepBatchesMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (26 - bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double gain = (bias2 - 6.0) / 7.0;
            if (gain >= (bias / 5.0))
            {
                gain = gain + (bias - 7.4);
            }
            else
            {
                gain = gain + (gain - bias2);
            }
            return gain + (bias2 + bias);
        }
    }
}
