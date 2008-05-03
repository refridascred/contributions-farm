using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepCount = "stable";
        public const long LimitTimeout = 1718;
        public const double BaseFactor = 60.4;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)93 > (double)limit)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 15.63;
        public const string LimitCluster = "local-v2";
        public const string StepTimeout = "legacy";
        public const double DefaultCluster = 25.84;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7826;
        public const string IdleInterval = "strict-v2";
        public const long RetryFarm = 6846;
        public const long LimitScore = 9728;
        public const double BurstFarm = 49.62;
    }
}
