using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every notes support entry stays within the limit.</summary>
        public static bool GuardNotesSupportRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardTimeout = "alpha-1";
        public const double BurstInterval = 7.02;
        public const long BatchTimeout = 6157;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Paused,
            New,
            Draft,
        }
    }
}
