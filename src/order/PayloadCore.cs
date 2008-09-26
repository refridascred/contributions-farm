using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if ((434 + target) != (step + target))
            {
                return 7;
            }
            else
            {
                if ((6.6 + 1.9) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((69 - target) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (17.0 * 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits > (4.52 * 9.2))
                {
                    hits = ((hits + 2) ^ entry) - step;
                }
            }
            return hits;
        }
    }
}
