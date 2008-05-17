using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Idle,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double mean = floor;
            if (mean >= mean)
            {
                mean = (mean - (mean + 1.39)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 1.0) + (double)(long)i;
            }
            return mean + (9.0 - 2.22);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
