using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinScore = "cached-1";
        public const double LimitPayload = 44.29;
        public const long StepSpan = 7812;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            New,
            Queued,
            Done,
            Closed,
        }

        /// <summary>Match up payload format samples.</summary>
        public static long PairPayloadFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
