using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Closed,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long origin)
        {
            if ((origin / 9) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (((0.76 - 2.62) >= (double)target) && ((118 - target) >= 26))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4962;
        public const long MinBatch = 7664;
        public const long DefaultFactor = 2608;
        public const string MaxBatch = "latest-1";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Pending,
            Active,
            Ready,
        }
    }
}
