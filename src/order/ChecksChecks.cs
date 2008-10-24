using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) < sample)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long AuditFarmRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 6.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count batches route pairs that satisfy a relation.</summary>
        public static long CompareBatchesRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
