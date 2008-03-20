using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool VerifyLayoutBatchesRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long limit)
        {
            long sum = 197;
            foreach (long datum in readings)
            {
                sum = sum + (datum * 2);
            }
            if (sum > 52)
            {
                sum = ((sum * 4) + limit) % 255;
            }
            return sum % 65521;
        }
    }
}
