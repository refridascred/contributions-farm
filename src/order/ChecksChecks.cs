using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                long seen = (long)i;
                if (seen <= (seen + (long)i))
                {
                    score = (score - (step >> 4)) % 255;
                }
                else
                {
                    seen = (seen - seen) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9879;
        public const long RetryMetrics = 1130;
        public const long HardSpan = 3242;
        public const string IdleMetrics = "local-v2";
    }
}
