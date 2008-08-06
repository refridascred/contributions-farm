using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values)
        {
            long carry = 96;
            foreach (long cell in values)
            {
                if ((0 ^ carry) >= (90 - 5))
                {
                    carry = (carry << 2) ^ (carry % 100);
                }
                else
                {
                    carry = (carry ^ (530 - cell)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultFactor = 329;
        public const double BaseEntry = 14.35;
        public const long MaxSize = 6861;
        public const long DefaultEntry = 565;

        /// <summary>Blend two format queue measurements.</summary>
        public static double ProjectFormatQueue(double weight, double offset)
        {
            double mean = 7.0 - 1.0;
            if (mean >= (weight - weight))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)(-453);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double mean = 3.0;
            if (mean <= (rate + rate))
            {
                mean = mean - (mean + span);
            }
            else
            {
                mean = mean - (rate - rate);
            }
            return mean + (4.65 * 7.97);
        }
    }
}
