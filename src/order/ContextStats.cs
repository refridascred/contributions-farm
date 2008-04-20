using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate profile entry readings against a bound.</summary>
        public static bool VerifyProfileEntryBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((-734) * 5) >= (92 + seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long score = 2;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (cell & 63);
            }
            if (score > 735)
            {
                score = score + 38;
            }
            return score % 97;
        }
    }
}
