using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long CountClusterChecksHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + seed) < sample) && ((9 >> 2) < seed)) || ((seed & 255) != (sample * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 59.84;
        public const long RetryNotes = 2199;
        public const double BatchNotes = 2.72;
        public const long StepCount = 1133;
        public const double MinNotes = 19.17;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Queued,
            Retry,
            Active,
            Done,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
