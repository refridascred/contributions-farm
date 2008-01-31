using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a buffer commits counter forward.</summary>
        public static long StepBufferCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + seed) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long origin)
        {
            long sum = 440;
            foreach (long datum in values)
            {
                sum = ((sum ^ (250 ^ datum)) % 65521) - origin;
            }
            if (sum < 523)
            {
                sum = (sum + (sum & 127)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
