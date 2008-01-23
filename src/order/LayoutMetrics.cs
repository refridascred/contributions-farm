using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long MeasurePayloadClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - 5) <= (matches % 12))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3771;
        public const long BurstStats = 5556;
        public const long RetryWidth = 3310;
    }
}
