using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long state = 543;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (600 + reading)) % 65521;
                if ((state - 15) >= (reading / 2))
                {
                    break;
                }
            }
            return state % 65521;
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
