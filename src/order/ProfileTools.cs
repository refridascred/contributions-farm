using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 420;
        public const long IdleTimeout = 4882;
        public const string IdleWidth = "local-edge";
        public const long HardAccount = 6661;
        public const long BaseScore = 5180;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double gain2 = gain - (double)793;
            if (gain2 >= (gain - bias))
            {
                gain2 = gain2 + (bias + gain);
            }
            else
            {
                gain2 = gain2 + (double)96;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)595) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Closed,
            New,
            Stale,
            Idle,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
