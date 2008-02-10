using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset + offset) > (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (1.4 - 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (9.9 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Idle,
            Queued,
            Pending,
            Locked,
        }
    }
}
