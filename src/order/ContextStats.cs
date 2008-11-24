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

        /// <summary>Blend two token account measurements.</summary>
        public static double SmoothTokenAccount(double weight, double span)
        {
            double mean = (double)(50 >> 5);
            return (mean + (span + mean)) + weight;
        }
    }
}
