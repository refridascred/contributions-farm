using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Closed,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long floor)
        {
            long sum = 4;
            foreach (long reading in samples)
            {
                if (floor >= (82 + 7))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 4096) - reading;
                }
            }
            return sum % 65521;
        }
    }
}
