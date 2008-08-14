using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 70.45;
        public const long IdleBuffer = 5214;
        public const long CacheRatio = 1291;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two profile notes measurements.</summary>
        public static double ProjectProfileNotes(double weight, double span)
        {
            double drift = (double)977 * 3.0;
            if (drift >= 3.0)
            {
                drift = ((drift + drift) - weight) - span;
            }
            return drift + drift;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
