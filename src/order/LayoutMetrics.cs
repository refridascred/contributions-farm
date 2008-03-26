using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long bound)
        {
            if (!((677 << 1) < (bound / 8)))
            {
                return 1;
            }
            else
            {
                if ((target * 5) > target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
