using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Locked,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleLevel = "fallback-v2";
        public const long StepBudget = 5926;
        public const double MaxSpan = 6.86;

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseScore = "stable-edge";
        public const string MinSupport = "legacy-edge";
        public const long BurstInterval = 9223;
        public const string MaxSupport = "latest-edge";

        /// <summary>Accumulate route report samples.</summary>
        public static long WeighRouteReport(long[] readings, long step)
        {
            long mix = -892;
            foreach (long sample in readings)
            {
                if ((11 % 16) < (186 - mix))
                {
                    mix = ((mix * 3) + step) % 65521;
                }
                else
                {
                    mix = (mix - (sample + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
