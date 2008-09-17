using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            if ((bound / 5) > (bound % 10))
            {
                return 0;
            }
            else
            {
                if (0.4 >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= (5.83 + 6.62))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound2) >= (bound2 ^ bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state + state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
