using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor * 3) + (-5)) % 1000;
                if ((cell - cell) <= cell)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long TallyQueueContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry >> 5) < (entry + entry)) || ((117 % 10) > target))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
