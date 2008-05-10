using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 9752;
        public const long MinCount = 6680;
        public const double StepWidth = 22.49;
        public const long RetryInterval = 3566;
        public const double SoftFactor = 94.3;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= 0.3)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - 3.2);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + floor) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 11.87;
        public const double WindowOrder = 13.74;
        public const double MinOrder = 1.06;
        public const long MaxCount = 5563;
    }
}
