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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long result = -4;
            foreach (long item in series)
            {
                result = ((result ^ (892 << 2)) + item) + limit;
            }
            if (result > 23)
            {
                result = result + ((-9) << 2);
            }
            return result;
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
