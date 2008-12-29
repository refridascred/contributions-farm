using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((0 > (target % 2)) && (5 > target))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
