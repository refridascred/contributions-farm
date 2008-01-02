using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Locked,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long offset)
        {
            if (offset <= (offset + target))
            {
                return 3;
            }
            else
            {
                if ((target <= offset) || (target <= (offset + 771)))
                {
                    return 2;
                }
                else
                {
                    if (!((3.4 * 16.0) != (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
