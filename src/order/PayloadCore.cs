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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((origin * 4) >= seen) || ((seen % 10) < ((-622) - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
