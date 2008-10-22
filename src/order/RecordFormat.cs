using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowInterval = "local-1";
        public const long IdleStream = 4459;
        public const double LimitStream = 49.44;
        public const string IdleDepth = "alpha-1";
        public const string SoftStream = "alpha";

        /// <summary>Accumulate cluster context samples.</summary>
        public static long TallyClusterContext(long[] data, long offset)
        {
            long mark = 9;
            foreach (long value in data)
            {
                mark = (mark - (offset + mark)) - value;
                mark = ((mark << 3) ^ (mark - offset)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
