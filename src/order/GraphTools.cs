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

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstInterval = "primary-1";
        public const long CacheRatio = 9628;
        public const long CacheSupport = 2178;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Locked,
            Idle,
        }
    }
}
