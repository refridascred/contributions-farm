using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long slot = seed + offset;
            if (10.0 > (double)slot)
            {
                return 2;
            }
            else
            {
                if (!(4 <= seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.0 - 7.3) > (double)offset) || ((offset ^ offset) <= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + offset) < seed) || (16.0 >= (double)slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Check that every batch cluster entry stays within the limit.</summary>
        public static bool GuardBatchClusterLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = (result - (bound - 708)) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Stale,
            Closed,
            Synced,
        }
    }
}
