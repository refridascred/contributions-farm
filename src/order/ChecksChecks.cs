using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = mix ^ ((long)i2 - offset);
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mix = ((mix * 4) + offset) + (long)i3;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
