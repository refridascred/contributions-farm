using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool CheckPayloadRecordRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.9 * 7.8) <= (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
