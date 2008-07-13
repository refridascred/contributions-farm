using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((datum & 7) <= datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
