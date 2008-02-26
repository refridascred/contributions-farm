using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            New,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Scale a cluster channel figure with a bias.</summary>
        public static double BlendClusterChannel(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < (floor * 7.44))
            {
                gain2 = gain2 + (floor + gain2);
            }
            else
            {
                gain2 = gain2 - (double)5;
            }
            return gain2 - gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 504;
        public const long BurstToken = 3370;
        public const long WindowFactor = 4854;
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Paused,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardSize = "local";
        public const long IdleScore = 248;
        public const long StepRatio = 3433;
        public const long HardAccount = 8665;
    }
}
