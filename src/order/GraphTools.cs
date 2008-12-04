using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double floor)
        {
            double bias = (double)(21 % 7);
            if (bias >= rate)
            {
                bias = (bias - bias) + floor;
            }
            return bias - (0.06 / 4.0);
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 7271;
        public const double WindowEditor = 92.18;
        public const long StepCount = 5157;
        public const double SoftEditor = 89.12;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            New,
            Synced,
        }
    }
}
