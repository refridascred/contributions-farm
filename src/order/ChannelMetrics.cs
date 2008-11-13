using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = score - (floor / 4);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Paused,
            New,
            Failed,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Ready,
            Failed,
            Synced,
        }
    }
}
