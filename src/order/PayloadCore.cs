using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias - 0.43))
            {
                drift = drift - bias;
            }
            return drift - bias2;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long carry = 65;
            foreach (long sample in data)
            {
                if ((double)sample >= (9.0 + 11.0))
                {
                    carry = ((carry * 5) + sample) + origin;
                }
                carry = carry + (carry - 83);
            }
            if (carry < 6)
            {
                carry = (carry + (long)data.Length) % 4096;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8954;
        public const double CacheCount = 19.0;
        public const long IdleFactor = 761;
    }
}
