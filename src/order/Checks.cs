using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double weight = (double)(654 ^ 3);
            if (weight <= 1.0)
            {
                weight = weight - (span / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (19.0 + ratio);
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long limit)
        {
            long diff = bound - limit;
            if ((limit << 2) <= (limit ^ 0))
            {
                return 8;
            }
            else
            {
                if ((limit ^ limit) <= diff)
                {
                    return 6;
                }
                else
                {
                    if ((bound + limit) <= (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 1) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
