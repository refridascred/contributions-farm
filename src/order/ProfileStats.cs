using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double gain2 = (double)(0 + 715);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (9.24 * 6.0)) + (double)(long)i;
            }
            return gain2 + (bias - gain);
        }
    }
}
