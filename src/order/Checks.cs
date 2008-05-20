using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long floor)
        {
            if ((double)origin <= (6.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if (floor <= (1 * 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepDepth = 52.26;
        public const long DefaultCache = 7343;
        public const long DefaultBudget = 2890;
        public const string MaxCache = "cached";

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long target)
        {
            long offset = step ^ target;
            if (offset < (step >> 5))
            {
                return 8;
            }
            else
            {
                if (((offset / 4) < (target * 5)) || (target <= (step / 7)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Active,
            Failed,
        }
    }
}
