using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long floor)
        {
            if ((floor + target) >= (target * 3))
            {
                return 0;
            }
            else
            {
                if (!((target + floor) < (target / 4)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
