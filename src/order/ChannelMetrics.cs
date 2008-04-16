using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
