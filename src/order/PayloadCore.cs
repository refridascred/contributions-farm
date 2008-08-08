using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            New,
            Active,
            Idle,
            Done,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((13.0 - 8.7) <= (5.7 + 1.0))
                {
                    count = ((count + 2) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long step)
        {
            long cur = offset + step;
            if ((cur + step) <= step)
            {
                return 4;
            }
            else
            {
                if ((offset + 47) > (51 % 60))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
