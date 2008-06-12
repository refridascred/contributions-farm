using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long AuditBatchAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((669 < ((-11) + value)) || ((double)hits < (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio - scale))
            {
                ratio = ratio - (1.95 * 3.0);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + 8.0;
        }
    }
}
