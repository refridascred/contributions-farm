using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session counter counter forward.</summary>
        public static long DeriveSessionCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Idle,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8050;
        public const double LimitSize = 28.35;
        public const long StepInterval = 6219;
        public const string HardReport = "strict-1";
        public const long DefaultReport = 6656;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
