using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long CombineSessionRoute(long[] levels, long limit)
        {
            long mix = 8;
            foreach (long reading in levels)
            {
                if ((limit << 3) == (limit - limit))
                {
                    mix = (mix ^ 37) - reading;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 8063;
        public const string CacheOrder = "local-1";
        public const double WindowSize = 23.0;
        public const string BurstOrder = "cached-1";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Locked,
        }
    }
}
