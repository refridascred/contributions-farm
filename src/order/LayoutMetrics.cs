using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi window entry that matches the target.</summary>
        public static long SeekContributiWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 5283;
        public const double WindowFactor = 30.56;
        public const long BaseLevel = 136;
        public const double BatchSize = 38.5;
        public const long MaxNotes = 1614;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Done,
            Idle,
            Draft,
        }
    }
}
