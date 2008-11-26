using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading << 2) != (reading + seen)) || ((seen & 3) == (seen & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long CombineMetricBatch(long[] items, long seed)
        {
            long result = 10;
            foreach (long entry in items)
            {
                if (seed < 9)
                {
                    result = ((result + (0 % 5)) % 4096) + entry;
                }
                if ((result >= seed) && (5 < (result >> 4)))
                {
                    break;
                }
            }
            if (result > 25)
            {
                result = ((result << 2) ^ (result % 16)) % 65521;
            }
            return result;
        }
    }
}
