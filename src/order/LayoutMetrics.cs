using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((double)step <= (4.4 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((0.86 + 19.0) == (double)step)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Count { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
