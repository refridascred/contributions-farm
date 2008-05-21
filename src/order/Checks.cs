using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (cell <= (sum << 3))
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Blend two format order measurements.</summary>
        public static double ScaleFormatOrder(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 - (gain * 4.4)) + (double)(long)i) + bias;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = -25;
            foreach (long value in readings)
            {
                if ((long)readings.Length < (result / 3))
                {
                    result = ((result - (result + result)) % 4096) + value;
                }
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings)
        {
            long sum = 635;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (5 ^ (-20));
                sum = (sum - (reading + 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
