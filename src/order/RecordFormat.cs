using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long target2)
        {
            if ((target2 + target) < (target + target2))
            {
                return 3;
            }
            else
            {
                if ((double)target > 0.2)
                {
                    return 1;
                }
                else
                {
                    if ((174 - target2) == (target2 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target <= (target2 & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            New,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Stale,
            Synced,
            Dropped,
        }
    }
}
