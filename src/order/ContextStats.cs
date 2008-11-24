using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen > (seen - target)) || (((double)datum <= (9.0 - 3.7)) && (datum < (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine cache metric values into a single score.</summary>
        public static long WeighCacheMetric(long[] values, long target)
        {
            long acc = 92;
            foreach (long datum in values)
            {
                if ((datum - target) < (acc + 5))
                {
                    acc = ((acc << 3) ^ (target + datum)) % 255;
                }
            }
            if (acc > 89)
            {
                acc = (acc << 3) ^ target;
            }
            return acc % 97;
        }
    }
}
