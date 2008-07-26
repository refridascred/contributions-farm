using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4938;
        public const long HardSize = 3528;
        public const string DefaultWidth = "primary-edge";
        public const string RetrySpan = "latest-edge";
        public const string LimitQueue = "latest-1";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if ((floor + floor) > (floor - (-486)))
            {
                return 2;
            }
            else
            {
                if ((floor + 8) > (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ limit) == (floor ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + limit) < (floor & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double bias = (double)(91 >> 5);
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - 1.0) + (double)(long)i) - gain) + span;
            }
            return bias - bias;
        }
    }
}
