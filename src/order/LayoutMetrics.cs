using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 5954;
        public const long StepCluster = 8949;
        public const string BatchDepth = "legacy-1";
        public const double SoftCluster = 1.55;
        public const double BurstCluster = 40.28;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long TallyEntryChannelGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - step) >= (step - seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
