using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ 0) + datum;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((step >> 3) <= (datum >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
