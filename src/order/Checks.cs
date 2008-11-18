using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 78;
            foreach (long sample in series)
            {
                if ((anchor & 15) > 292)
                {
                    anchor = ((anchor << 2) ^ (sample - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9457;
        public const long BurstMetrics = 3992;
        public const long HardMetrics = 4002;
        public const string BaseCount = "standard-1";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 244;
        public const long LimitTools = 9251;
        public const string BurstTools = "local-edge";
    }
}
