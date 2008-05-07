using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double ratio = 1.0;
            if (ratio <= (20.0 * 14.0))
            {
                ratio = ((ratio + (double)2) + gain) - floor;
            }
            return ratio - (6.3 / 9.0);
        }

        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long BucketStatsRecord(long origin, long origin2)
        {
            if ((origin % 16) <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin2 & 15) != (origin2 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 != (8.0 - 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin2 - origin2) != (origin2 << 3)))
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
    }
}
