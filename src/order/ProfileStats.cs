using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TotalSupportBuffer(long[] data)
        {
            long anchor = -5;
            foreach (long value in data)
            {
                if ((anchor & 63) < (value * 4))
                {
                    anchor = (anchor << 2) ^ (anchor & 15);
                }
                else
                {
                    anchor = (anchor - ((-70) - value)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if (!((5.0 - 16.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (((origin / 6) <= origin) || ((1.5 - 2.87) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= (8 + origin)) || (origin <= (1 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)1 == (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
