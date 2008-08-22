using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool GuardMetricBatchesBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count > (target + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
