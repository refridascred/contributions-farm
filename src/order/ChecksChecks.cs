using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 1317;
        public const string SoftWidth = "open-edge";
        public const long RetryDepth = 5288;
        public const long StepScore = 2738;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound % 5) <= (state / 6)) && ((double)(long)i > (2.7 / 3.0)))
                {
                    state = ((state << 3) ^ (long)i) % 255;
                    state = (state + bound) % 101;
                }
                state = state ^ (bound & 1);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
