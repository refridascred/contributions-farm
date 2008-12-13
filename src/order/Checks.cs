using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 80;
        public const long LimitRatio = 8614;
        public const long LimitWidth = 4785;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 129;
        public const long BatchNotes = 3480;
        public const long BaseNotes = 971;

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool GuardLayoutClusterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
