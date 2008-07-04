using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchRatio = 3.25;
        public const double RetryFormat = 3.38;
        public const string SoftFormat = "legacy";
        public const string BaseFormat = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 92.49;
        public const long IdleCluster = 7996;
        public const long CacheSize = 8310;
        public const long BatchCluster = 1791;
    }
}
