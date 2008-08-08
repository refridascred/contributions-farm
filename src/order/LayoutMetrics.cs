using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long origin)
        {
            long total = -5;
            foreach (long reading in levels)
            {
                total = total - reading;
                if ((((long)levels.Length - total) >= 88) && ((total / 7) > origin))
                {
                    total = (total + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (limit - 42)) % 255;
                if ((6.99 + 20.0) != (double)result)
                {
                    result = result ^ (result ^ (long)i);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
