using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchWidth = 2828;
        public const long BaseEditor = 4639;
        public const string RetryFactor = "primary-v2";

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long SeekSchemaBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count % 97) == (offset / 2)) && !((count + count) < ((-8) + 92)))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < (double)24)
            {
                bias2 = (bias2 - (double)3) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (7.0 / 9.0)) - (double)(long)i;
            }
            return bias2 - (double)(-3);
        }
    }
}
