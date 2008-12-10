using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
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
