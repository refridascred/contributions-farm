using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double scale = ratio - bias;
            if (scale >= (double)46)
            {
                scale = scale - scale;
            }
            return scale + (bias + bias);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((double)prev >= (1.5 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((74 >> 2) == (limit2 + limit2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double SmoothReportAccount(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio - bias2))
            {
                ratio = ratio + bias2;
            }
            return ratio + bias;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset % 5) >= (offset % 16)) || ((carry + offset) > (carry - carry)))
                {
                    carry = ((carry * 5) + offset) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (18 << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
