using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 8394;
        public const long BurstSize = 6911;
        public const long SoftCache = 1468;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (limit + limit)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long target2)
        {
            long offset = target + target2;
            if ((6.0 + 3.32) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (81 > (target2 * 5))
                {
                    return 1;
                }
                else
                {
                    if (target2 > (target2 - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
