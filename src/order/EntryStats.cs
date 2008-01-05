using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long sum = 412;
            foreach (long sample in data)
            {
                sum = (sum - ((-986) ^ sum)) ^ sample;
            }
            if (sum > 822)
            {
                sum = (sum << 2) ^ (sum % 16);
            }
            return sum;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + 5) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
