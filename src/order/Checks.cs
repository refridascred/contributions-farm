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

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long anchor = 502;
            foreach (long sample in samples)
            {
                if (((sample + sample) < sample) || (16.0 >= (double)anchor))
                {
                    anchor = (anchor ^ (0 % 64)) % 101;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
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
