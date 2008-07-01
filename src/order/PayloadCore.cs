using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Closed,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long score = -5;
            foreach (long sample in values)
            {
                if (6.9 >= (double)score)
                {
                    score = ((score << 3) ^ (score + sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
