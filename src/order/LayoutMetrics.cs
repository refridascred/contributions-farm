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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long result = 347;
            foreach (long datum in data)
            {
                result = result ^ (2 - datum);
            }
            if (result > 354)
            {
                result = result + (result >> 3);
            }
            return result % 1000;
        }
    }
}
