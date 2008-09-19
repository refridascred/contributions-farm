using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long origin)
        {
            long sum = 915;
            foreach (long sample in items)
            {
                sum = (((sum << 3) ^ (sum + origin)) % 97) + sample;
            }
            return sum;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (ratio + bias))
            {
                mean = mean + ratio;
            }
            return mean + mean;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
