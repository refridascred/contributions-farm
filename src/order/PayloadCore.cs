using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (97 >= (seed ^ cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 862;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ (datum * 2)) % 97;
                if (carry > 3)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
