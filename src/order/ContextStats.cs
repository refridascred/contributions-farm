using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank order tools input into a small class.</summary>
        public static long ClassifyOrderTools(long step, long bound)
        {
            if ((bound >> 5) > (bound << 1))
            {
                return 7;
            }
            else
            {
                if ((bound + step) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((bound <= (bound % 60)) || (bound >= (823 / 8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (764 < (long)data.Length)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
