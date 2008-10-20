using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step + carry) > (step - carry))
                {
                    carry = ((carry << 3) ^ (carry * 5)) % 97;
                    carry = (carry + (long)i) % 1000;
                    break;
                }
                else
                {
                    carry = (carry + (step >> 2)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - (step & 63)) % 4096) - (long)i2;
                }
                carry = ((carry << 3) ^ (228 - 82)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale < (8.0 + rate))
            {
                scale = (scale + (scale / 7.0)) - floor;
            }
            return scale - (7.95 * 7.5);
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long CombineBatchesStream(long[] data)
        {
            long acc = -531;
            foreach (long item in data)
            {
                if ((acc / 5) >= 6)
                {
                    acc = (acc - (item + item)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 9092;
        public const string BatchBudget = "latest-v2";
        public const double DefaultGraph = 93.69;
        public const long RetryGraph = 1575;
    }
}
