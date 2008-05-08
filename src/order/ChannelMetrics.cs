using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepPayload = 64.22;
        public const long BasePayload = 5272;
        public const long DefaultPayload = 620;
    }
}
