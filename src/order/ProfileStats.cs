using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double span)
        {
            double scale2 = scale - span;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 - scale2;
        }

        /// <summary>Check that every notes contributi entry stays within the limit.</summary>
        public static bool ValidateNotesContributiBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 297;
        public const double CacheToken = 39.11;
        public const double StepToken = 40.81;
        public const long BurstToken = 7546;
    }
}
