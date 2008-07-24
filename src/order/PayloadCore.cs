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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)offset >= (18.0 / 5.0))
                {
                    mix = (mix + 148) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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
