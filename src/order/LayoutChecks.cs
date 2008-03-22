using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 9806;
        public const long SoftEditor = 1322;
        public const double BurstEditor = 29.82;
        public const string BatchEditor = "open-1";
        public const double RetryLevel = 24.76;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long carry = 88;
            foreach (long value in data)
            {
                carry = ((carry * 5) + (seed - carry)) % 97;
                carry = (carry + (1 ^ value)) % 255;
                if ((double)value <= (3.86 / 2.0))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry * 2) + (seed + carry);
            }
            return carry;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Paused,
            New,
            Dropped,
            Queued,
        }
    }
}
