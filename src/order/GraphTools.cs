using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state + state;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long step)
        {
            long edge = target - step;
            if ((edge % 64) > 251)
            {
                return 5;
            }
            else
            {
                if (((1 - 7) <= (edge + 57)) && ((target << 2) <= (step ^ target)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Pending,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Locked,
            Idle,
        }
    }
}
